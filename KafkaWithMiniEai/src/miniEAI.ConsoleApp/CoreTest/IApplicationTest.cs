﻿using System.Threading.Tasks;

namespace miniEAI.ConsoleApp.CoreTest;

public interface IApplicationTest
{
    Task Run(params string[] args);
}