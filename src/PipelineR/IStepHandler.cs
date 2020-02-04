﻿using System;

namespace PipelineR.Interface
{
    public interface IStepHandler<TContext> where TContext : class
    {
        Func<TContext, bool> Condition { get; set; }

        TContext Context { get; }

        IStepHandler<TContext> NextStep { get; set; }

        StepHandlerResult HandleStep();
    }
}