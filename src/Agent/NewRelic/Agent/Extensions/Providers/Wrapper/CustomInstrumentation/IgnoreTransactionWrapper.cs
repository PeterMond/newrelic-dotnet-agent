﻿/*
* Copyright 2020 New Relic Corporation. All rights reserved.
* SPDX-License-Identifier: Apache-2.0
*/
using System.Linq;
using NewRelic.Agent.Extensions.Providers.Wrapper;

namespace NewRelic.Providers.Wrapper.CustomInstrumentation
{
    public class IgnoreTransactionWrapper : IWrapper
    {
        private static readonly string[] PossibleWrapperNames = {
            "NewRelic.Providers.Wrapper.CustomInstrumentation.IgnoreTransactionWrapper",

            // To support older custom instrumentation we need to also accept the old tracer factory name
            "NewRelic.Agent.Core.Tracer.Factories.IgnoreTransactionTracerFactory"
        };

        public bool IsTransactionRequired => false;

        public CanWrapResponse CanWrap(InstrumentedMethodInfo instrumentedMethodInfo)
        {
            var canWrap = PossibleWrapperNames.Contains(instrumentedMethodInfo.RequestedWrapperName);
            return new CanWrapResponse(canWrap);
        }

        public AfterWrappedMethodDelegate BeforeWrappedMethod(InstrumentedMethodCall instrumentedMethodCall, IAgentWrapperApi agentWrapperApi, ITransaction transaction)
        {
            agentWrapperApi.CurrentTransaction.Ignore();
            return Delegates.NoOp;
        }
    }
}