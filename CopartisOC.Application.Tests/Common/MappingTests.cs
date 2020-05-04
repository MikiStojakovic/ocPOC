using AutoMapper;
using CopartisOC.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CopartisOC.Application.Tests.Common
{
    public class MappingTests
    {
        private readonly IConfigurationProvider _configuration;
        private readonly IMapper _mapper;

        public MappingTests()
        {
            _configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = _configuration.CreateMapper();
        }

        [Fact]
        public void ShouldHaveValidConfiguration()
        {
            _configuration.AssertConfigurationIsValid();
        }

        //TODO: Should be rewriten for xUnit
        //[Test]
        //[TestCase(typeof(TodoList), typeof(TodoListDto))]
        //[TestCase(typeof(TodoItem), typeof(TodoItemDto))]
        //public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
        //{
        //    var instance = Activator.CreateInstance(source);

        //    _mapper.Map(instance, source, destination);
        //}
    }
}
