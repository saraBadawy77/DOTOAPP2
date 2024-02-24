using DOTOAPP1.Entities;
using DOTOAPP1.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace DOTOAPP1
{
    public class TodoItemAppService:DOTOAPP1AppService
    {
        private readonly IRepository<TodoItem, Guid> _todoItemRepository;

        public TodoItemAppService(IRepository<TodoItem, Guid> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public async Task<List<TodoItemDto>> GetALL()
        {
            var TodoItems = await _todoItemRepository.GetListAsync();


           
            return  ObjectMapper.Map<List<TodoItem>, List<TodoItemDto>>(TodoItems);
        }





    }
}
