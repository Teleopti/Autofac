﻿// This software is part of the Autofac IoC container
// Copyright (c) 2007 - 2008 Autofac Contributors
// http://autofac.org
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.


namespace Autofac.Component.Activation
{
    /// <summary>
    /// Executes the ConstructorInfo directly.
    /// </summary>
    public class DirectConstructorInvoker : IConstructorInvoker
    {
        /// <summary>
        /// Invokes the constructor.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="ci">The selected constructor.</param>
        /// <param name="args">Arguments appropriate to the constructor.</param>
        /// <returns>The new instance.</returns>
        public object InvokeConstructor(IContext context, IActivationParameters parameters, System.Reflection.ConstructorInfo ci, object[] args)
        {
            Enforce.ArgumentNotNull(ci, "ci");
            Enforce.ArgumentNotNull(args, "args");
            return ci.Invoke(args);
        }
    }
}