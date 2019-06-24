using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using <%= nomeProj %>.domain.domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace <%= nomeProj %>.presentation.webapi.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuario;

        public UsuarioController(IUsuarioRepository _usuario)
        {
            this._usuario = _usuario;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _usuario.AllAsync());
        }
    }
}