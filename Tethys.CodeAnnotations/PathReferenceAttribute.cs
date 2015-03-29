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
// <copyright file="PathReferenceAttribute.cs" company="Tethys">
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
    /// Indicates that a parameter is a path to a file or a folder
    /// within a web project. Path can be relative or absolute,
    /// starting from web root (~)
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class PathReferenceAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PathReferenceAttribute"/> class.
        /// </summary>
        public PathReferenceAttribute()
        {
        } // PathReferenceAttribute()

        /// <summary>
        /// Initializes a new instance of the <see cref="PathReferenceAttribute"/> class.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public PathReferenceAttribute([PathReference] string basePath)
        {
            this.BasePath = basePath;
        } // PathReferenceAttribute()

        /// <summary>
        /// Gets the base path.
        /// </summary>
        [NotNull]
        public string BasePath { get; private set; }
    } // PathReferenceAttribute
} // Tethys.CodeAnnotations