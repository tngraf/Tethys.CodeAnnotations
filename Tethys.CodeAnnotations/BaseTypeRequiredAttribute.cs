#region Header
// --------------------------------------------------------------------------
// Tethys.CodeAnnotations
// ==========================================================================
//
// A library that implements some of the useful code annotations that can
// automatically get checked by JetBrains ReSharper.
//
// ===========================================================================
//
// <copyright file="BaseTypeRequiredAttribute.cs" company="Tethys">
// Copyright (c) 2007-2012 JetBrains s.r.o. 
// Copyright for modification by Thomas Graf.
//            Licensed under the Apache License, Version 2.0.
//            Unless required by applicable law or agreed to in writing, 
//            software distributed under the License is distributed on an
//            "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
//            either express or implied. 
// </copyright>
//
// System ... Microsoft .Net Framework 4.5.1
// Tools .... Microsoft Visual Studio 2013
//
// ---------------------------------------------------------------------------
#endregion

#pragma warning disable 1591
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedParameter.Local
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable IntroduceOptionalParameters.Global
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable InconsistentNaming
namespace Tethys.CodeAnnotations
{
    using System;

    /// <summary>
    /// When applied to a target attribute, specifies a requirement for any type marked
    /// with the target attribute to implement or inherit specific type or types.
    /// </summary>
    /// <example><code>
    /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
    /// public class ComponentAttribute : Attribute { }
    /// [Component] // ComponentAttribute requires implementing IComponent interface
    /// public class MyComponent : IComponent { }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    [BaseTypeRequired(typeof(Attribute))]
    public sealed class BaseTypeRequiredAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTypeRequiredAttribute"/> 
        /// class.
        /// </summary>
        /// <param name="baseType">Type of the base.</param>
        public BaseTypeRequiredAttribute([NotNull] Type baseType)
        {
            this.BaseType = baseType;
        } // BaseTypeRequiredAttribute()

        /// <summary>
        /// Gets the type of the base.
        /// </summary>
        [NotNull]
        public Type BaseType { get; private set; }
    } // BaseTypeRequiredAttribute
} // Tethys.CodeAnnotations