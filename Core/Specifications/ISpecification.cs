using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
   public class ISpecification<T>
   {
      private Expression<Func<T, bool>> Criteria { get; }
      private List<Expression<Func<T, object>>> Includes { get; }
   }
}