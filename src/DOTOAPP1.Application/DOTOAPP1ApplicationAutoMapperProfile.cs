using AutoMapper;
using DOTOAPP1.Entities;

namespace DOTOAPP1;

public class DOTOAPP1ApplicationAutoMapperProfile : Profile
{
    public DOTOAPP1ApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<TodoOne, TodoOneDto>();
        CreateMap<TodoOneDto, TodoOne>();

        CreateMap<TodoItem, TodoItemDto>();
        CreateMap<TodoItemDto, TodoItem>();


        CreateMap<TestTable,TestTableDto>();
        CreateMap<TestTableDto, TestTable>();
    }
}
