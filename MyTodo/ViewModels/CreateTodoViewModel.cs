﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTodo.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public string Title { get; set; }
    }
}
