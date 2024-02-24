using AutoMapper;
using AutoMapper.Internal.Mappers;
using DOTOAPP1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace DOTOAPP1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly IRepository<TodoItem, Guid> _todoItemRepository;
        private readonly IMapper _mapper;
        public TodoItemController(IRepository<TodoItem, Guid> todoItemRepository, IMapper mapper)
        {
            _todoItemRepository = todoItemRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<TodoItemDto>> GetAllitemdto()
        {
            var TodoItems = await _todoItemRepository.GetListAsync();
            var todoItemDtos = _mapper.Map<List<TodoItemDto>>(TodoItems);
            return todoItemDtos;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(Guid id)
        {
            var todoItem = await _todoItemRepository.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }



    }
}
