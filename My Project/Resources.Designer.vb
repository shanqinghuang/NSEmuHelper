﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("NSEmuHelper.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  重写当前线程的 CurrentUICulture 属性，对
        '''  使用此强类型资源类的所有资源查找执行重写。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找类似 {&quot;CF1&quot;:{&quot;name&quot;:&quot;Cloudflare&quot;,&quot;ghapi_url&quot;:&quot;https://rp.ydz1.gq/https://api.github.com&quot;,&quot;fwmd5_url&quot;:&quot;https://rp.ydz1.gq/https://ia801909.us.archive.org/4/items/nintendo-switch-global-firmwares/nintendo-switch-global-firmwares_files.xml&quot;,&quot;fwfull_url&quot;:&quot;https://rp.ydz1.gq/https://ia801909.us.archive.org/4/items/nintendo-switch-global-firmwares/nintendo-switch-global-firmwares_files.xml&quot;},&quot;AWS1&quot;:{&quot;name&quot;:&quot;AWS 1&quot;,&quot;ghapi_url&quot;:&quot;https://ghapi.aws1.nsemuhelper.yidaozhan.top&quot;,&quot;fwmd5_url&quot;:&quot;https://ghapi.aws1.nsemuhelper.yi [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property Backends() As String
            Get
                Return ResourceManager.GetString("Backends", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property bilibili() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bilibili", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 {&quot;OneDrive&quot;:{&quot;name&quot;:&quot;OneDrive AWS | 助手自建&quot;,&quot;type&quot;:&quot;onemanager&quot;,&quot;url&quot;:&quot;https://download.aws1.nsemuhelper.yidaozhan.top/ns_emu_helper/&quot;},&quot;Direct&quot;:{&quot;name&quot;:&quot;GitHub 直连&quot;,&quot;type&quot;:&quot;github&quot;,&quot;url&quot;:&quot;https://github.com&quot;},&quot;US1&quot;:{&quot;name&quot;:&quot;美国 1 | CDN&quot;,&quot;type&quot;:&quot;github&quot;,&quot;url&quot;:&quot;https://gh.ddlc.top/https://github.com&quot;},&quot;US2&quot;:{&quot;name&quot;:&quot;美国 2 | 圣何塞&quot;,&quot;type&quot;:&quot;github&quot;,&quot;url&quot;:&quot;https://download.xn--p8jhe.tw&quot;},&quot;US3&quot;:{&quot;name&quot;:&quot;日本东京 | CDN | 助手自建&quot;,&quot;type&quot;:&quot;onemanager&quot;,&quot;url&quot;:&quot;https://download.aws1.nsemuhelper.yidaozhan.top/ns_emu_helper/&quot;},&quot;US4&quot;: [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property DownloadSources() As String
            Get
                Return ResourceManager.GetString("DownloadSources", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property firmware() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("firmware", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property github() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("github", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property hammer_wrench() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("hammer-wrench", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property nintendo_switch() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nintendo-switch", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property qq() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("qq", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property ryujinx() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ryujinx", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property ryujinx_icon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("ryujinx_icon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property wan() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("wan", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property yuzu() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("yuzu", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property yuzu_icon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("yuzu_icon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property yuzu_mainline() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("yuzu-mainline", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
