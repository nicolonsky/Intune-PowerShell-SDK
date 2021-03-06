// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.detectedApp&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.detectedApp&quot; objects in the &quot;detectedApps&quot; collection.</para>
    ///     <para type="description">The list of detected apps associated with a device.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/detectedApps</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DeviceManagement_DetectedApps", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.detectedApp")]
    [ResourceTypePropertyName("detectedAppODataType")]
    [ResourceReference]
    [Alias("Get-IntuneDetectedApp")]
    public class Get_DeviceManagement_DetectedApps : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String detectedAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Name of the discovered application. Read-only</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Version of the discovered application. Read-only</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sizeInByte&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Discovered application size in bytes. Read-only</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Sortable]
        public System.Int64 sizeInByte { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">The number of devices that have installed this application</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 deviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">The devices that have the discovered application installed</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevice")]
        [Selectable]
        [Expandable]
        public System.Object[] managedDevices { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{detectedAppId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.detectedApp&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.detectedApp&quot; object to the &quot;detectedApps&quot; collection.</para>
    ///     <para type="description">The list of detected apps associated with a device.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/detectedApps</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DeviceManagement_DetectedApps", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.detectedApp")]
    [ODataType("microsoft.graph.detectedApp")]
    [ResourceTypePropertyName("detectedAppODataType")]
    [ResourceReference]
    [Alias("New-IntuneDetectedApp")]
    public class New_DeviceManagement_DetectedApps : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String detectedAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Name of the discovered application. Read-only</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.detectedApp", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Version of the discovered application. Read-only</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.detectedApp", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sizeInByte&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Discovered application size in bytes. Read-only</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.detectedApp", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sizeInByte&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sizeInByte&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 sizeInByte { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">The number of devices that have installed this application</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.detectedApp", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">The devices that have the discovered application installed</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevice")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.detectedApp", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.")]
        public System.Object[] managedDevices { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{detectedAppId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.detectedApp&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
    ///     <para type="description">The list of detected apps associated with a device.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/detectedApps</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DeviceManagement_DetectedApps", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.detectedApp")]
    [ODataType("microsoft.graph.detectedApp")]
    [ResourceTypePropertyName("detectedAppODataType")]
    [Alias("Update-IntuneDetectedApp")]
    public class Update_DeviceManagement_DetectedApps : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String detectedAppId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Name of the discovered application. Read-only</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.detectedApp", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Version of the discovered application. Read-only</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.detectedApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sizeInByte&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">Discovered application size in bytes. Read-only</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.detectedApp", HelpMessage = @"The &quot;sizeInByte&quot; property, of type &quot;Edm.Int64&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;sizeInByte&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 sizeInByte { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">The number of devices that have installed this application</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.detectedApp", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.detectedApp&quot; type.</para>
        ///     <para type="description">The devices that have the discovered application installed</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDevice")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.detectedApp", HelpMessage = @"The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;managedDevices&quot; property, of type &quot;microsoft.graph.managedDevice&quot;.")]
        public System.Object[] managedDevices { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{detectedAppId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.detectedApp&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.detectedApp&quot; object from the &quot;detectedApps&quot; collection.</para>
    ///     <para type="description">The list of detected apps associated with a device.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/detectedApps/detectedAppId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DeviceManagement_DetectedApps", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.detectedApp")]
    [ResourceTypePropertyName("detectedAppODataType")]
    [Alias("Remove-IntuneDetectedApp")]
    public class Remove_DeviceManagement_DetectedApps : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.detectedApp&quot; object in the &quot;detectedApps&quot; collection.")]
        public System.String detectedAppId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/detectedApps/{detectedAppId}";
        }
    }
}