using System;

using AnimalShelter.Api.Filters;

namespace AnimalShelter.Api.Services
{
  public interface IUriService
  {
    public Uri GetPageUri(PaginationFilter filter, string route);
  }
}