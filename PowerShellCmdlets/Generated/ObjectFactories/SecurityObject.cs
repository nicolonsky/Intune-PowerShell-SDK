// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.security&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.security&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SecurityObject", DefaultParameterSetName = @"microsoft.graph.security")]
    [ODataType("microsoft.graph.security")]
    public class New_SecurityObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;alerts&quot; property, of type &quot;microsoft.graph.alert&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.security&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.alert")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.security", HelpMessage = @"The &quot;alerts&quot; property, of type &quot;microsoft.graph.alert&quot;.")]
        public System.Object[] alerts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;secureScoreControlProfiles&quot; property, of type &quot;microsoft.graph.secureScoreControlProfile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.security&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.secureScoreControlProfile")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.security", HelpMessage = @"The &quot;secureScoreControlProfiles&quot; property, of type &quot;microsoft.graph.secureScoreControlProfile&quot;.")]
        public System.Object[] secureScoreControlProfiles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;secureScores&quot; property, of type &quot;microsoft.graph.secureScore&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.security&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.secureScore")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.security", HelpMessage = @"The &quot;secureScores&quot; property, of type &quot;microsoft.graph.secureScore&quot;.")]
        public System.Object[] secureScores { get; set; }
    }
}