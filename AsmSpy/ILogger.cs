﻿namespace AsmSpy
{
    public interface ILogger
    {
        void LogMessage(string message);
        void LogError(string message);
        void LogWarning(string message);
    }
}
