﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressMapper
{
    public interface IMappingService
    {
        IDictionary<int, ITypeMapper> TypeMappers { get; }
        IDictionary<int, MulticastDelegate> CollectionMappers { get; }
        void PrecompileCollection<T, TN>();
        bool DestinationSupport { get; }
        MulticastDelegate MapCollection(int cacheKey);
        void Reset();
        BlockExpression MapCollection(Type srcColtype, Type destColType, Expression srcExpression, Expression destExpression);
        Expression GetDifferentTypeMemberMappingExpression(Expression srcExpression, Expression destExpression, bool newDest);
        BlockExpression MapProperty(Type srcType, Type destType, Expression srcExpression, Expression destExpression, bool newDest);
        Expression GetMemberMappingExpression(Expression left, Expression right, bool newDest);
        Expression GetMemberQueryableExpression(Type srcType, Type dstType);
        void Compile();
    }
}
