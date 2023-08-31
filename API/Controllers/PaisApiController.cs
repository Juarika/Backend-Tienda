using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class PaisApiController : BaseApiController
{
    private readonly IUnitOfWork unitOfWork;
    public PaisApiController(IUnitOfWork _unitOfWork)
    {
        this.unitOfWork = _unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Pais>>> Get()
    {
        var paises = await unitOfWork.Paises.GetAllAsync();
        return Ok(paises);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<IActionResult> Get(int id)
    {
        var pais = await unitOfWork.Paises.GetByIdAsync(id);
        return Ok(pais);
    } 

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Pais>>> Post(Pais pais)
    {
        unitOfWork.Paises.Add(pais);
        await unitOfWork.SaveAsync();
        if (pais == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = pais.Id}, pais);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Pais>>> Delete(Pais pais)
    {
        unitOfWork.Paises.Remove(pais);
        await unitOfWork.SaveAsync();
        if (pais == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = pais.Id}, pais);
    }
}