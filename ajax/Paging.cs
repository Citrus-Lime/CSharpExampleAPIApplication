// <copyright file="Paging.cs" company="CitrusLime Ltd">
// Copyright (c) CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Ajax
{
    /// <summary>Paging.</summary>
    public class Paging
    {
        /// <summary>The total count.</summary>
        public int TotalCount;

        /// <summary>The page size.</summary>
        public int PageSize;

        /// <summary>The current page.</summary>
        public int CurrentPage;

        /// <summary>The total pages.</summary>
        public int TotalPages;

        /// <summary>The previous page.</summary>
        public string PreviousPage;

        /// <summary>The next page.</summary>
        public string NextPage;
    }
}
