'
' Enhanced Permissions Provider for DotNetNuke® - http://www.oliverhine.com
' Copyright (c) 2009
' by Oliver Hine
'
Imports System.Collections.Generic

Imports DotNetNuke.ComponentModel
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Entities.Tabs
Imports DotNetNuke.Services.FileSystem
Imports DotNetNuke.Security.Permissions

Namespace OliverHine.Provider.EnhancedPermissions

    Partial Class Implementation
        Inherits PermissionProvider

        'Private dataProvider As DotNetNuke.Data.DataProvider = DotNetNuke.Data.DataProvider.Instance()

#Region "Constants"

        'Filesystem Permission Codes
        Private Const AdminFolderPermissionCode As String = "WRITE"
        Private Const AddFolderPermissionCode As String = "ADD"
        Private Const CopyFolderPermissionCode As String = "COPY"
        Private Const DeleteFolderPermissionCode As String = "DELETE"
        Private Const ManageFolderPermissionCode As String = "MANAGE"
        Private Const ViewFolderPermissionCode As String = "READ"

        'Module Permission Codes
        Private Const AdminModulePermissionCode As String = "EDIT"
        Private Const ContentModulePermissionCode As String = "CONTENT"
        Private Const DeleteModulePermissionCode As String = "DELETE"
        Private Const ExportModulePermissionCode As String = "EXPORT"
        Private Const ImportModulePermissionCode As String = "IMPORT"
        Private Const ManageModulePermissionCode As String = "MANAGE"
        Private Const ViewModulePermissionCode As String = "VIEW"

        'Page Permission Codes
        Private Const AddPagePermissionCode As String = "ADD"
        Private Const AdminPagePermissionCode As String = "EDIT"
        Private Const ContentPagePermissionCode As String = "CONTENT"
        Private Const CopyPagePermissionCode As String = "COPY"
        Private Const DeletePagePermissionCode As String = "DELETE"
        Private Const ExportPagePermissionCode As String = "EXPORT"
        Private Const ImportPagePermissionCode As String = "IMPORT"
        Private Const ManagePagePermissionCode As String = "MANAGE"
        Private Const NavigatePagePermissionCode As String = "NAV"
        Private Const ViewPagePermissionCode As String = "VIEW"

#End Region
        
#Region "Public Properties"
        Public Overrides ReadOnly Property LocalResourceFile() As String
            Get
                Return IO.Path.Combine(Config.GetProviderPath("permissions"), "App_LocalResources\EnhancedPermissionProvider.resx")
            End Get
        End Property
#End Region

#Region "FolderPermission Methods"

        Public Overrides Function CanAdminFolder(ByVal folder As FolderInfo) As Boolean
            Return PortalSecurity.IsInRoles(folder.FolderPermissions.ToString(AdminFolderPermissionCode))
        End Function

        Public Overrides Function CanAddFolder(ByVal folder As FolderInfo) As Boolean
            Return PortalSecurity.IsInRoles(folder.FolderPermissions.ToString(AddFolderPermissionCode))
        End Function

        Public Overrides Function CanCopyFolder(ByVal folder As FolderInfo) As Boolean
            Return PortalSecurity.IsInRoles(folder.FolderPermissions.ToString(CopyFolderPermissionCode))
        End Function

        Public Overrides Function CanDeleteFolder(ByVal folder As FolderInfo) As Boolean
            Return PortalSecurity.IsInRoles(folder.FolderPermissions.ToString(DeleteFolderPermissionCode))
        End Function

        Public Overrides Function CanManageFolder(ByVal folder As FolderInfo) As Boolean
            Return PortalSecurity.IsInRoles(folder.FolderPermissions.ToString(ManageFolderPermissionCode))
        End Function

        Public Overrides Function CanViewFolder(ByVal folder As FolderInfo) As Boolean
            Return PortalSecurity.IsInRoles(folder.FolderPermissions.ToString(ViewFolderPermissionCode))
        End Function

#End Region

#Region "ModulePermission Methods"

        Public Overrides Function CanAdminModule(ByVal objModule As ModuleInfo) As Boolean
            Return PortalSecurity.IsInRoles(objModule.ModulePermissions.ToString(AdminModulePermissionCode))
        End Function

        Public Overrides Function CanDeleteModule(ByVal objModule As ModuleInfo) As Boolean
            Return PortalSecurity.IsInRoles(objModule.ModulePermissions.ToString(DeleteModulePermissionCode))
        End Function

        Public Overrides Function CanEditModuleContent(ByVal objModule As ModuleInfo) As Boolean
            Return PortalSecurity.IsInRoles(objModule.ModulePermissions.ToString(ContentModulePermissionCode))
        End Function

        Public Overrides Function CanExportModule(ByVal objModule As ModuleInfo) As Boolean
            Return PortalSecurity.IsInRoles(objModule.ModulePermissions.ToString(ExportModulePermissionCode))
        End Function

        Public Overrides Function CanImportModule(ByVal objModule As ModuleInfo) As Boolean
            Return PortalSecurity.IsInRoles(objModule.ModulePermissions.ToString(ImportModulePermissionCode))
        End Function

        Public Overrides Function CanManageModule(ByVal objModule As ModuleInfo) As Boolean
            Return PortalSecurity.IsInRoles(objModule.ModulePermissions.ToString(ManageModulePermissionCode))
        End Function

        Public Overrides Function CanViewModule(ByVal objModule As ModuleInfo) As Boolean
            Return PortalSecurity.IsInRoles(objModule.ModulePermissions.ToString(ViewModulePermissionCode))
        End Function



#End Region

#Region "TabPermission Methods"

        Public Overrides Function CanAddContentToPage(ByVal objTab As TabInfo) As Boolean
            Return PortalSecurity.IsInRoles(objTab.TabPermissions.ToString(ContentPagePermissionCode))
        End Function

        Public Overrides Function CanAddPage(ByVal objTab As TabInfo) As Boolean
            Return PortalSecurity.IsInRoles(objTab.TabPermissions.ToString(AddPagePermissionCode))
        End Function

        Public Overrides Function CanAdminPage(ByVal objTab As TabInfo) As Boolean
            Return PortalSecurity.IsInRoles(objTab.TabPermissions.ToString(AdminPagePermissionCode))
        End Function

        Public Overrides Function CanCopyPage(ByVal objTab As TabInfo) As Boolean
            Return PortalSecurity.IsInRoles(objTab.TabPermissions.ToString(CopyPagePermissionCode))
        End Function

        Public Overrides Function CanDeletePage(ByVal objTab As TabInfo) As Boolean
            Return PortalSecurity.IsInRoles(objTab.TabPermissions.ToString(DeletePagePermissionCode))
        End Function

        Public Overrides Function CanExportPage(ByVal objTab As TabInfo) As Boolean
            Return PortalSecurity.IsInRoles(objTab.TabPermissions.ToString(ExportPagePermissionCode))
        End Function

        Public Overrides Function CanImportPage(ByVal objTab As TabInfo) As Boolean
            Return PortalSecurity.IsInRoles(objTab.TabPermissions.ToString(ImportPagePermissionCode))
        End Function

        Public Overrides Function CanManagePage(ByVal objTab As TabInfo) As Boolean
            Return PortalSecurity.IsInRoles(objTab.TabPermissions.ToString(ManagePagePermissionCode))
        End Function

        Public Overrides Function CanNavigateToPage(ByVal objTab As TabInfo) As Boolean
            Return PortalSecurity.IsInRoles(objTab.TabPermissions.ToString(NavigatePagePermissionCode))
        End Function

        Public Overrides Function CanViewPage(ByVal objTab As TabInfo) As Boolean
            Return PortalSecurity.IsInRoles(objTab.TabPermissions.ToString(ViewPagePermissionCode))
        End Function
#End Region

    End Class

End Namespace

