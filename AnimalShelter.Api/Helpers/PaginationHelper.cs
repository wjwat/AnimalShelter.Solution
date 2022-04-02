using System;
using System.Collections.Generic;
using System.Web;

using AnimalShelter.Api.Filters;
using AnimalShelter.Api.Services;
using AnimalShelter.Api.Wrappers;

namespace AnimalShelter.Api.Helpers
{
  class PaginationHelper
  {
    public static PagedResponse<List<T>> CreatePagedResponse<T>(
        List<T> pagedData,
        PaginationFilter validFilter,
        int totalRecords,
        IUriService uriService,
        string route
    )
    {
      string strippedRoute = StripPageFilterParams(route);
      var response = new PagedResponse<List<T>>(
          pagedData,
          validFilter.PageNumber,
          validFilter.PageSize
      );
      var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
      int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

      if (validFilter.PageNumber >= 1 && validFilter.PageNumber < roundedTotalPages)
      {
        response.NextPage = uriService.GetPageUri(
            new PaginationFilter(
                validFilter.PageNumber + 1,
                validFilter.PageSize
            ),
            strippedRoute
        );
      }
      else
      {
        response.NextPage = null;
      }

      if (validFilter.PageNumber - 1 >= 1 && validFilter.PageNumber <= roundedTotalPages)
      {
        response.PreviousPage = uriService.GetPageUri(
            new PaginationFilter(
                validFilter.PageNumber - 1,
                validFilter.PageSize
            ),
            strippedRoute
        );
      }
      else
      {
        response.PreviousPage = null;
      }

      response.FirstPage = uriService.GetPageUri(new PaginationFilter(1, validFilter.PageSize), strippedRoute);
      response.LastPage = uriService.GetPageUri(new PaginationFilter(roundedTotalPages, validFilter.PageSize), strippedRoute);
      response.TotalPages = roundedTotalPages;
      response.TotalRecords = totalRecords;

      return response;
    }

    private static string StripPageFilterParams(string routePart)
    {
      var newQueryString = HttpUtility.ParseQueryString(routePart);

      newQueryString.Remove("pageNumber");
      newQueryString.Remove("pageSize");

      return newQueryString.ToString();
    }
  }
}
