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
// <copyright file="PublicAPIAttribute.cs" company="Tethys">
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
    /// This attribute is intended to mark publicly available API
    /// which should not be removed and so is treated as used
    /// </summary>
    [MeansImplicitUse]
    public sealed class PublicAPIAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAPIAttribute"/> class.
        /// </summary>
        public PublicAPIAttribute()
        {
        } // PublicAPIAttribute()

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAPIAttribute"/> class.
        /// </summary>
        /// <param name="comment">The comment.</param>
        public PublicAPIAttribute([NotNull] string comment)
        {
            this.Comment = comment;
        } // PublicAPIAttribute()

        /// <summary>
        /// Gets the comment.
        /// </summary>
        [NotNull]
        public string Comment { get; private set; }
    } // PublicAPIAttribute
} // Tethys.CodeAnnotations