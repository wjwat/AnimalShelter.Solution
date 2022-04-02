using Microsoft.AspNetCore.WebUtilities;
using System;

using AnimalShelter.Api.Filters;

namespace AnimalShelter.Api.Services
{
  public class UriService : IUriService
  {
    public UriService(string baseUri)
    {
      _baseUri = baseUri;
    }

    private readonly string _baseUri;

    public Uri GetPageUri(PaginationFilter filter, string route)
    {
      var endpointUri = new Uri(string.Concat(_baseUri, route));
      var modifiedUri = QueryHelpers.AddQueryString(
          endpointUri.ToString(),
          "pageNumber",
          filter.PageNumber.ToString());
      modifiedUri = QueryHelpers.AddQueryString(
          modifiedUri,
          "pageSize",
          filter.PageSize.ToString());
      
      return new Uri(modifiedUri);
    }
  }
}
