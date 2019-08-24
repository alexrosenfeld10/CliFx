﻿using System.Threading.Tasks;
using CliFx.Attributes;
using CliFx.Services;

namespace CliFx.Tests.Services
{
    public partial class CommandFactoryTests
    {
        [Command]
        private class TestCommand : ICommand
        {
            public Task ExecuteAsync(IConsole console) => Task.CompletedTask;
        }
    }
}