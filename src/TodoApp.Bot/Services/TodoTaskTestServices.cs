﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Domain.Model;
using TodoApp.Services;

namespace TodoApp.Bot.Services
{
    public class TodoTaskTestServices : ITodoTaskServices
    {
        List<TodoTask> _tasks;

        public TodoTaskTestServices()
        {
            _tasks = new List<TodoTask>();
        }


        public async Task AddTask(TodoTask task)
        {
            _tasks.Add(task);
        }

        public async Task<List<TodoTask>> GetTasks()
        {
            return _tasks;
        }
    }

    public static class ConfigureTestServicesExtensions
    {
        public static void AddTodoAppTestServices(this IServiceCollection services)
        {
            services.AddSingleton<ITodoTaskServices>(sp => new TodoTaskTestServices());
        }
    }
}
