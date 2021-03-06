﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SearchRequestViewModel.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

using BetterCms.Module.Root.ViewModels.Cms;
using BetterCms.Module.Search.Content.Resources;

namespace BetterCms.Module.Search.ViewModels
{
    public class SearchRequestViewModel
    {
        public SearchRequestViewModel()
        {
            Skip = 0;
            Take = SearchModuleConstants.DefaultSearchResultsCount;
        }

        public int Skip { get; set; }
        
        public int Take { get; set; }

        [StringLength(SearchModuleConstants.SearchQueryMaximumLength, ErrorMessageResourceType = typeof(SearchGlobalization), ErrorMessageResourceName = "SearchForm_Query_MaximumLengthMessage")]
        [AllowHtml]
        public string Query { get; set; }

        public RenderWidgetViewModel WidgetModel { get; set; }
    }
}