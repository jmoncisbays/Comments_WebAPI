using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommentsWebAPI.Models;
using CommentsWebAPI.Repositories;

namespace CommentsWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private ICommentRepository _repository;

        public CommentsController(ICommentRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Returns all Comments
        /// </summary>
        /// <remarks></remarks>
        /// <returns>
        /// IEnumerable<Comment>
        /// </returns>
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return _repository.GetAll;
        }

        /// <summary>
        /// Add a Comment
        /// </summary>
        /// <param name="comment"></param>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Post([FromBody] Comment comment)
        {
            try
            {
                _repository.Add(comment);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}