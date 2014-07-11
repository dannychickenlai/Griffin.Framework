﻿using System;
using System.Data;
using Griffin.Data.Mapper;

namespace Griffin.Core.Tests.Data.Mapper.TestMappings
{
    public abstract class ClassThatHaveAnAbstractMapperMapper : CrudEntityMapper<ClassThatHaveAnAbstractMapper>
    {
        protected ClassThatHaveAnAbstractMapperMapper(string tableName) : base(tableName)
        {
        }

       
    }
}