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
// <copyright file="UsedImplicitlyAttribute.cs" company="Tethys">
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
    /// Indicates that the marked symbol is used implicitly
    /// (e.g. via reflection, in external library), so this symbol
    /// will not be marked as unused (as well as by other usage inspections)
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public sealed class UsedImplicitlyAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsedImplicitlyAttribute"/> class.
        /// </summary>
        public UsedImplicitlyAttribute()
            : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
        {
        } // UsedImplicitlyAttribute()

        /// <summary>
        /// Initializes a new instance of the <see cref="UsedImplicitlyAttribute"/> class.
        /// </summary>
        /// <param name="useKindFlags">The use kind flags.</param>
        public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
            : this(useKindFlags, ImplicitUseTargetFlags.Default)
        {
        } // UsedImplicitlyAttribute()

        /// <summary>
        /// Initializes a new instance of the <see cref="UsedImplicitlyAttribute"/> class.
        /// </summary>
        /// <param name="targetFlags">The target flags.</param>
        public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
            : this(ImplicitUseKindFlags.Default, targetFlags)
        {
        } // UsedImplicitlyAttribute()

        /// <summary>
        /// Initializes a new instance of the <see cref="UsedImplicitlyAttribute"/> class.
        /// </summary>
        /// <param name="useKindFlags">The use kind flags.</param>
        /// <param name="targetFlags">The target flags.</param>
        public UsedImplicitlyAttribute(
          ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
        {
            this.UseKindFlags = useKindFlags;
            this.TargetFlags = targetFlags;
        } // UsedImplicitlyAttribute()

        /// <summary>
        /// Gets the use kind flags.
        /// </summary>
        public ImplicitUseKindFlags UseKindFlags { get; private set; }

        /// <summary>
        /// Gets the target flags.
        /// </summary>
        public ImplicitUseTargetFlags TargetFlags { get; private set; }
    } // UsedImplicitlyAttribute
} // Tethys.CodeAnnotations