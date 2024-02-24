using AutoMapper;
using DOTOAPP1.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace DOTOAPP1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly IRepository<TestTable, Guid> _testTableRepository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public TestController(IRepository<TestTable, Guid> todoItemRepository, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _testTableRepository = todoItemRepository;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }




        [HttpGet]
        public async Task<ActionResult<List<TestTableDto>>> Get()
        {
            var entities = await _testTableRepository.GetListAsync();
            var dtos = _mapper.Map<List<TestTableDto>>(entities);
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TestTableDto>> Get(Guid id)
        {
            var entity = await _testTableRepository.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            var dto = _mapper.Map<TestTableDto>(entity);
            return Ok(dto);
        }


        [HttpPost]
        public async Task<ActionResult<TestTableDto>> Create([FromForm] TestTableDto input,List<IFormFile> files)
        {
            // Save files to wwwroot/paths directory
            var pathsDirectory = Path.Combine(_webHostEnvironment.WebRootPath, "paths");
            if (!Directory.Exists(pathsDirectory))
            {
                Directory.CreateDirectory(pathsDirectory);
            }

            List<string> logosPaths = new List<string>();
            foreach (var file in files)
            {
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                var filePath = Path.Combine(pathsDirectory, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                logosPaths.Add($"paths/{fileName}");
            }

            input.LogosPaths = logosPaths;

            var entity = _mapper.Map<TestTable>(input);
            entity = await _testTableRepository.InsertAsync(entity);
            var dto = _mapper.Map<TestTableDto>(entity);
            return CreatedAtAction(nameof(Get), new { id = dto.Id }, dto);
        }




        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, TestTableDto input)
        {
            var entity = await _testTableRepository.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            entity.name = input.name;
            entity.name2 = input.name2;
            entity.LogosPaths = input.LogosPaths;

            await _testTableRepository.UpdateAsync(entity);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var entity = await _testTableRepository.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            await _testTableRepository.DeleteAsync(id);

            return NoContent();
        }
    }
}
