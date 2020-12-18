<!DOCTYPE html>
<html><head><title>stackbuildersink.cs</title><link rel="stylesheet" href="../../../../styles.css"><script src="../../../../scripts.js"></script></head>
<body class="cB" onload="i(534);"><div class="dH">
<table style="width: 100%">
<tr><td>File: <a id="filePath" class="blueLink" href="/#mscorlib/system/runtime/remoting/stackbuildersink.cs" target="_top">system\runtime\remoting\stackbuildersink.cs</a><br/></td><td></td></tr>
<tr><td>Project: <a id="projectPath" class="blueLink" href="/#mscorlib" target="_top">ndp\clr\src\bcl\mscorlib.csproj</a> (mscorlib)</td><td></td></tr>
</table>
</div>
<div class="cz"><table class="tb" cellpadding="0" cellspacing="0"><tr><td valign="top" align="right"><pre id="ln"></pre></td><td valign="top" align="left"><pre id="code">
<span class="c">// ==++==</span>
<span class="c">// </span>
<span class="c">//   Copyright (c) Microsoft Corporation.  All rights reserved.</span>
<span class="c">// </span>
<span class="c">// ==--==</span>
<span class="c">/*============================================================
**
** File:    StackBuilderSink.cs
**
**
** Purpose: Terminating sink which will build a stack and 
**          make a method call on an object
**
**
===========================================================*/</span>
<b>namespace</b> System.Runtime.Remoting.Messaging {
    <b>using</b> System.Runtime.InteropServices;
    <b>using</b> System.Runtime.Remoting;
    <b>using</b> System.Runtime.Remoting.Channels;
    <b>using</b> System.Runtime.Remoting.Metadata;
    <b>using</b> System.Reflection;
    <b>using</b> System.Runtime.CompilerServices;
    <b>using</b> System.Runtime.Versioning;
    <b>using</b> System.Security.Principal;
    <span class="c">/* Assembly Access */</span>
    <b>using</b> System;
    <b>using</b> System.Globalization;
    <b>using</b> System.Threading;
 
    [<a href="../../serializableattribute.cs.html#e971d5381ca60183" class="t">Serializable</a>]
    <b>internal class</b> <a id="2a8dc7fbc4a1308c" href="../../../R/2a8dc7fbc4a1308c.html" target="n" data-glyph="2,0" class="t">StackBuilderSink</a> : <a href="imessagesink.cs.html#e7887b7c8d4e9e16" class="t">IMessageSink</a>
    {
 
        <span class="c">//+============================================================</span>
        <span class="c">//</span>
        <span class="c">// Method:     Constructor, public</span>
        <span class="c">//</span>
        <span class="c">// Synopsis:   Store server object</span>
        <span class="c">//</span>
        <span class="c">// History:    06-May-1999  &lt;EMAIL&gt;MattSmit&lt;/EMAIL&gt;   Created</span>
        <span class="c">//-============================================================</span>
        <b>public</b> <a id="8bac5de6c3283ed0" href="../../../R/8bac5de6c3283ed0.html" target="n" data-glyph="72,1">StackBuilderSink</a>(<a href="../../marshalbyrefobject.cs.html#8ec9f4cbed5b7726" class="t">MarshalByRefObject</a> <span id="r0 rd" class="r0 r">server</span>)
        {
            <a href="#c74d683002f4447b">_server</a> = <span class="r0 r">server</span>;
        }
        <b>public</b> <a id="06c64f26fcfb4be1" href="../../../R/06c64f26fcfb4be1.html" target="n" data-glyph="72,1">StackBuilderSink</a>(<a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <span id="r1 rd" class="r1 r">server</span>)
        {
            <a href="#c74d683002f4447b">_server</a> = <span class="r1 r">server</span>;
            <b>if</b> (<a href="#c74d683002f4447b">_server</a>==<b>null</b>)
            {
                <a href="#598eece71f716b28">_bStatic</a> = <b>true</b>;
            }
        }
 
        [System.Security.<a href="../../security/attributes.cs.html#29a3d687a50338b1" class="t">SecurityCritical</a>]  <span class="c">// auto-generated</span>
        <b>public virtual</b> <a href="imessage.cs.html#38b4f0bd82d93b25" class="t">IMessage</a> <a id="6b0d129cdbf4b59a" href="../../../R/6b0d129cdbf4b59a.html" target="n" data-glyph="72,1">SyncProcessMessage</a>(<a href="imessage.cs.html#38b4f0bd82d93b25" class="t">IMessage</a> <span id="r2 rd" class="r2 r">msg</span>)
        {
            <span class="c">// Validate message here </span>
            <a href="imessage.cs.html#38b4f0bd82d93b25" class="t">IMessage</a> <span id="r3 rd" class="r3 r">errMsg</span> = <a href="terminatorsinks.cs.html#2a6acfac154afd71" class="t">InternalSink</a>.<a href="terminatorsinks.cs.html#b91eb910137afaf5">ValidateMessage</a>(<span class="r2 r">msg</span>);        
            <b>if</b> (<span class="r3 r">errMsg</span> != <b>null</b>)
            {
                <b>return</b> <span class="r3 r">errMsg</span>;
            }
 
            <a href="imethodmessage.cs.html#4573589286a4a8d8" class="t">IMethodCallMessage</a> <span id="r4 rd" class="r4 r">mcMsg</span> = <span class="r2 r">msg</span> <b>as</b> <a href="imethodmessage.cs.html#4573589286a4a8d8" class="t">IMethodCallMessage</a>;            
 
            <a href="imessage.cs.html#38b4f0bd82d93b25" class="t">IMessage</a> <span id="r5 rd" class="r5 r">retMessage</span>;
            <a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a> <span id="r6 rd" class="r6 r">oldCallCtx</span> = <b>null</b>;
 
            <a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a> <span id="r7 rd" class="r7 r">lcc</span> = <a href="../../threading/thread.cs.html#3980e012bae82e96" class="t">Thread</a>.<a href="../../threading/thread.cs.html#89653a7faafd4d23">CurrentThread</a>.<a href="../../threading/thread.cs.html#9d638a3b7cd843df">GetMutableExecutionContext</a>().<a href="../../threading/executioncontext.cs.html#2e09d198ef651abc">LogicalCallContext</a>;
            <b>object</b> <span id="r8 rd" class="r8 r">xADCall</span> = <span class="r7 r">lcc</span>.<a href="callcontext.cs.html#9d66b09026774ca7">GetData</a>(<a href="crossappdomainchannel.cs.html#4559df3a138b5071" class="t">CrossAppDomainSink</a>.<a href="crossappdomainchannel.cs.html#6c9db351b1eafe34">LCC_DATA_KEY</a>);
            
            <b>bool</b> <span id="r9 rd" class="r9 r">isCallContextSet</span> = <b>false</b>;
            <b>try</b>
            {
                <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <span id="r10 rd" class="r10 r">server</span> = <a href="#c74d683002f4447b">_server</a>;
 
                <a href="../../bcldebug.cs.html#e30488e330156f1b" class="t">BCLDebug</a>.<a href="../../bcldebug.cs.html#236a609eef21dbb5">Assert</a>((<span class="r10 r">server</span>!=<b>null</b>) == (!<a href="#598eece71f716b28">_bStatic</a>),
                                <span class="s">&quot;Invalid state in stackbuilder sink?&quot;</span>);
 
                <span class="c">// validate the method base if necessary</span>
                <a href="#109e12650870518e">VerifyIsOkToCallMethod</a>(<span class="r10 r">server</span>, <span class="r4 r">mcMsg</span>);
                
                <span class="c">// install call context onto the thread, holding onto</span>
                <span class="c">// the one that is currently on the thread</span>
   
                <a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a> <span id="r11 rd" class="r11 r">messageCallContext</span> = <b>null</b>;
                <b>if</b> (<span class="r4 r">mcMsg</span> != <b>null</b>)
                {
                    <span class="r11 r">messageCallContext</span> = <span class="r4 r">mcMsg</span>.<a href="imethodmessage.cs.html#e8e49315d331c8d1">LogicalCallContext</a>;                    
                }
                <b>else</b>
                {
                    <span class="r11 r">messageCallContext</span> = (<a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a>)<span class="r2 r">msg</span>.<a href="imessage.cs.html#ec512e7e34a9f4f8">Properties</a><a href="../../collections/idictionary.cs.html#121995d2df15485a">[</a><span class="s">&quot;__CallContext&quot;</span>];
                }
                                
                <span class="r6 r">oldCallCtx</span> = <a href="callcontext.cs.html#f3ccc254455c175e" class="t">CallContext</a>.<a href="callcontext.cs.html#bfba16cc826cb8e4">SetLogicalCallContext</a>(<span class="r11 r">messageCallContext</span>);
                <span class="r9 r">isCallContextSet</span> = <b>true</b>;
 
                <span class="r11 r">messageCallContext</span>.<a href="callcontext.cs.html#33f4d22d5e6226b2">PropagateIncomingHeadersToCallContext</a>(<span class="r2 r">msg</span>);
 
                <a href="#880d9bc9ce8d576c">PreserveThreadPrincipalIfNecessary</a>(<span class="r11 r">messageCallContext</span>, <span class="r6 r">oldCallCtx</span>);
                
 
                <span class="c">// NOTE: target for dispatch will be NULL when the StackBuilderSink</span>
                <span class="c">// is used for async delegates on static methods.</span>
 
                <span class="c">// *** NOTE ***</span>
                <span class="c">// Although we always pass _server to these calls in the EE,</span>
                <span class="c">// when we execute using Message::Dispatch we are using TP as </span>
                <span class="c">// the this-ptr ... (what the call site thinks is the this-ptr)</span>
                <span class="c">// when we execute using StackBuilderSink::PrivatePM we use</span>
                <span class="c">// _server as the this-ptr (which could be different if there</span>
                <span class="c">// is interception for strictly MBR types in the same AD).</span>
                <span class="c">// ************</span>
                <b>if</b> (<a href="#0c0479d44f8ec202">IsOKToStackBlt</a>(<span class="r4 r">mcMsg</span>, <span class="r10 r">server</span>) 
                    &amp;&amp; ((<a href="message.cs.html#575d97bdd0a2c995" class="t">Message</a>)<span class="r4 r">mcMsg</span>).<a href="message.cs.html#d6c7cb78e4b93ec8">Dispatch</a>(<span class="r10 r">server</span>))
                {
                    <span class="c">//retMessage = StackBasedReturnMessage.GetObjectFromPool((Message)mcMsg);</span>
                    <span class="r5 r">retMessage</span> = <b>new</b> <a href="message.cs.html#20fb7e6557e30476" class="t">StackBasedReturnMessage</a>();
                    ((<a href="message.cs.html#e509e5cb812a811a" class="t">StackBasedReturnMessage</a>)<span class="r5 r">retMessage</span>).<a href="message.cs.html#9e28fb8f82b452b5">InitFields</a>((<a href="message.cs.html#575d97bdd0a2c995" class="t">Message</a>)<span class="r4 r">mcMsg</span>);
 
                    <span class="c">// call context could be different then the one from before the call.</span>
                    <a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a> <span id="r12 rd" class="r12 r">latestCallContext</span> = <a href="../../threading/thread.cs.html#3980e012bae82e96" class="t">Thread</a>.<a href="../../threading/thread.cs.html#89653a7faafd4d23">CurrentThread</a>.<a href="../../threading/thread.cs.html#9d638a3b7cd843df">GetMutableExecutionContext</a>().<a href="../../threading/executioncontext.cs.html#2e09d198ef651abc">LogicalCallContext</a>;
                    <span class="c">// retrieve outgoing response headers</span>
                    <span class="r12 r">latestCallContext</span>.<a href="callcontext.cs.html#6ed00a6a8f181a23">PropagateOutgoingHeadersToMessage</a>(<span class="r5 r">retMessage</span>);
                    
                    <span class="c">// Install call context back into Message (from the thread)</span>
                    ((<a href="message.cs.html#e509e5cb812a811a" class="t">StackBasedReturnMessage</a>)<span class="r5 r">retMessage</span>).<a href="message.cs.html#6077751d60a611d7">SetLogicalCallContext</a>(<span class="r12 r">latestCallContext</span>);
                } 
                <b>else</b>
                {
                    <a href="../../reflection/methodbase.cs.html#1383b72169c6b2ae" class="t">MethodBase</a> <span id="r13 rd" class="r13 r">mb</span> = <a href="#0a8e5ddb0b74d567">GetMethodBase</a>(<span class="r4 r">mcMsg</span>); 
                    <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[] <span id="r14 rd" class="r14 r">outArgs</span> = <b>null</b>;
                    <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <span id="r15 rd" class="r15 r">ret</span> = <b>null</b>;                      
                    
                    <a href="remotingattributes.cs.html#bd139a1135e89a2e" class="t">RemotingMethodCachedData</a> <span id="r16 rd" class="r16 r">methodCache</span> = 
                        <a href="remotingservices.cs.html#0c192c4a05ae5a98" class="t">InternalRemotingServices</a>.<a href="remotingservices.cs.html#cabc9454b7caf89d">GetReflectionCachedData</a>(<span class="r13 r">mb</span>);
 
                    <a href="message.cs.html#575d97bdd0a2c995" class="t">Message</a>.<a href="message.cs.html#7594347092d67f94">DebugOut</a>(<span class="s">&quot;StackBuilderSink::Calling PrivateProcessMessage\n&quot;</span>);
 
                    <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[] <span id="r17 rd" class="r17 r">args</span> = <a href="message.cs.html#575d97bdd0a2c995" class="t">Message</a>.<a href="message.cs.html#fee6cc27bdf5f8ba">CoerceArgs</a>(<span class="r4 r">mcMsg</span>, <span class="r16 r">methodCache</span>.<a href="remotingattributes.cs.html#a1c43aaf2f55df75">Parameters</a>);
                
                    <span class="r15 r">ret</span> = <a href="#7670282d17030ab4">PrivateProcessMessage</a>(
                                        <span class="r13 r">mb</span>.<a href="../../reflection/methodbase.cs.html#4d3bf777482b2f84">MethodHandle</a>,
                                        <span class="r17 r">args</span>,
                                        <span class="r10 r">server</span>,
                                        <b>out</b> <span class="r14 r">outArgs</span>); 
                    <a href="#07adba7d0b87483a">CopyNonByrefOutArgsFromOriginalArgs</a>(<span class="r16 r">methodCache</span>, <span class="r17 r">args</span>, <b>ref</b> <span class="r14 r">outArgs</span>);
 
 
                    <span class="c">// call context could be different then the one from before the call.</span>
                    <a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a> <span id="r18 rd" class="r18 r">latestCallContext</span> = <a href="../../threading/thread.cs.html#3980e012bae82e96" class="t">Thread</a>.<a href="../../threading/thread.cs.html#89653a7faafd4d23">CurrentThread</a>.<a href="../../threading/thread.cs.html#9d638a3b7cd843df">GetMutableExecutionContext</a>().<a href="../../threading/executioncontext.cs.html#2e09d198ef651abc">LogicalCallContext</a>;
 
                    <b>if</b> (<span class="r8 r">xADCall</span> != <b>null</b> &amp;&amp; ((<b>bool</b>)<span class="r8 r">xADCall</span>) == <b>true</b> &amp;&amp; <span class="r18 r">latestCallContext</span> != <b>null</b>)
                    {
                        <span class="c">// Special case Principal since if might not be serializable before returning</span>
                        <span class="c">// ReturnMessage</span>
                        <span class="r18 r">latestCallContext</span>.<a href="callcontext.cs.html#3fe488520306671b">RemovePrincipalIfNotSerializable</a>();
                    }
 
                    <span class="r5 r">retMessage</span> = <b>new</b> <a href="message.cs.html#9a5b84b2ab0d35ed" class="t">ReturnMessage</a>( 
                                        <span class="r15 r">ret</span>, 
                                        <span class="r14 r">outArgs</span>, 
                                        (<span class="r14 r">outArgs</span> == <b>null</b> ? 0 : <span class="r14 r">outArgs</span>.<a href="../../array.cs.html#42e9b7616956cf94">Length</a>),
                                        <span class="r18 r">latestCallContext</span>,
                                        <span class="r4 r">mcMsg</span>);
 
                    <span class="c">// retrieve outgoing response headers</span>
                    <span class="r18 r">latestCallContext</span>.<a href="callcontext.cs.html#6ed00a6a8f181a23">PropagateOutgoingHeadersToMessage</a>(<span class="r5 r">retMessage</span>);
                    <span class="c">// restore the call context on the thread</span>
                    <a href="callcontext.cs.html#f3ccc254455c175e" class="t">CallContext</a>.<a href="callcontext.cs.html#bfba16cc826cb8e4">SetLogicalCallContext</a>(<span class="r6 r">oldCallCtx</span>);
                }
 
 
            } <b>catch</b> (<a href="../../exception.cs.html#f092fb2b893a0162" class="t">Exception</a> <span id="r19 rd" class="r19 r">e</span>)
            {
                <a href="message.cs.html#575d97bdd0a2c995" class="t">Message</a>.<a href="message.cs.html#7594347092d67f94">DebugOut</a>(
                <span class="s">&quot;StackBuilderSink::The server object probably threw an exception &quot;</span> +
                                 <span class="r19 r">e</span>.<a href="../../exception.cs.html#5fba0e16215b42a3">Message</a> + <span class="r19 r">e</span>.<a href="../../exception.cs.html#950d763693dd32d3">StackTrace</a> + <span class="s">&quot;\n&quot;</span> );
                <span class="r5 r">retMessage</span> = <b>new</b> <a href="message.cs.html#b3ea8b70726ff28d" class="t">ReturnMessage</a>(<span class="r19 r">e</span>, <span class="r4 r">mcMsg</span>);
                ((<a href="message.cs.html#967c76cf26b767ba" class="t">ReturnMessage</a>)<span class="r5 r">retMessage</span>).<a href="message.cs.html#4fa4d844eba8e355">SetLogicalCallContext</a>(<span class="r4 r">mcMsg</span>.<a href="imethodmessage.cs.html#e8e49315d331c8d1">LogicalCallContext</a>);
                        
                <b>if</b> (<span class="r9 r">isCallContextSet</span>)
                    <a href="callcontext.cs.html#f3ccc254455c175e" class="t">CallContext</a>.<a href="callcontext.cs.html#bfba16cc826cb8e4">SetLogicalCallContext</a>(<span class="r6 r">oldCallCtx</span>);
            }
 
 
            <b>return</b> <span class="r5 r">retMessage</span>;
        }
 
 
        [System.Security.<a href="../../security/attributes.cs.html#29a3d687a50338b1" class="t">SecurityCritical</a>]  <span class="c">// auto-generated</span>
        <b>public virtual</b> <a href="imessagectrl.cs.html#c63597b001e6a276" class="t">IMessageCtrl</a> <a id="8d655f693a63cdbe" href="../../../R/8d655f693a63cdbe.html" target="n" data-glyph="72,1">AsyncProcessMessage</a>(
            <a href="imessage.cs.html#38b4f0bd82d93b25" class="t">IMessage</a> <span id="r20 rd" class="r20 r">msg</span>, <a href="imessagesink.cs.html#e7887b7c8d4e9e16" class="t">IMessageSink</a> <span id="r21 rd" class="r21 r">replySink</span>) 
        { 
            <a href="imethodmessage.cs.html#4573589286a4a8d8" class="t">IMethodCallMessage</a> <span id="r22 rd" class="r22 r">mcMsg</span> = (<a href="imethodmessage.cs.html#4573589286a4a8d8" class="t">IMethodCallMessage</a>)<span class="r20 r">msg</span>;
 
            <a href="imessagectrl.cs.html#c63597b001e6a276" class="t">IMessageCtrl</a> <span id="r23 rd" class="r23 r">retCtrl</span> = <b>null</b>;
            <a href="imessage.cs.html#38b4f0bd82d93b25" class="t">IMessage</a> <span id="r24 rd" class="r24 r">retMessage</span> = <b>null</b>;
            <a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a> <span id="r25 rd" class="r25 r">oldCallCtx</span> = <b>null</b>;
            <b>bool</b> <span id="r26 rd" class="r26 r">isCallContextSet</span> = <b>false</b>;
            <b>try</b>{
                <b>try</b>
                {
                    <a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a> <span id="r27 rd" class="r27 r">callCtx</span> =  (<a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a>)
                        <span class="r22 r">mcMsg</span>.<a href="imessage.cs.html#ec512e7e34a9f4f8">Properties</a><a href="../../collections/idictionary.cs.html#121995d2df15485a">[</a><a href="message.cs.html#575d97bdd0a2c995" class="t">Message</a>.<a href="message.cs.html#3b58f19bd46659cb">CallContextKey</a>];
                        
                    <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <span id="r28 rd" class="r28 r">server</span> = <a href="#c74d683002f4447b">_server</a>;
 
                    <span class="c">// validate the method base if necessary</span>
                    <a href="#109e12650870518e">VerifyIsOkToCallMethod</a>(<span class="r28 r">server</span>, <span class="r22 r">mcMsg</span>);
                    
                    <span class="c">// install call context onto the thread, holding onto</span>
                    <span class="c">// the one that is currently on the thread</span>
 
                    <span class="r25 r">oldCallCtx</span> = <a href="callcontext.cs.html#f3ccc254455c175e" class="t">CallContext</a>.<a href="callcontext.cs.html#bfba16cc826cb8e4">SetLogicalCallContext</a>(<span class="r27 r">callCtx</span>);
                    <span class="r26 r">isCallContextSet</span> = <b>true</b>;
                    <span class="c">// retrieve incoming headers</span>
                    <span class="r27 r">callCtx</span>.<a href="callcontext.cs.html#33f4d22d5e6226b2">PropagateIncomingHeadersToCallContext</a>(<span class="r20 r">msg</span>);
 
                    <a href="#880d9bc9ce8d576c">PreserveThreadPrincipalIfNecessary</a>(<span class="r27 r">callCtx</span>, <span class="r25 r">oldCallCtx</span>);
 
                    <span class="c">// see if this is a server message that was dispatched asynchronously</span>
                    <a href="channelsinkstacks.cs.html#8db29d6e0bdc4369" class="t">ServerChannelSinkStack</a> <span id="r29 rd" class="r29 r">sinkStack</span> = 
                        <span class="r20 r">msg</span>.<a href="imessage.cs.html#ec512e7e34a9f4f8">Properties</a><a href="../../collections/idictionary.cs.html#121995d2df15485a">[</a><span class="s">&quot;__SinkStack&quot;</span>] <b>as</b> <a href="channelsinkstacks.cs.html#8db29d6e0bdc4369" class="t">ServerChannelSinkStack</a>;
                    <b>if</b> (<span class="r29 r">sinkStack</span> != <b>null</b>)
                        <span class="r29 r">sinkStack</span>.<a href="channelsinkstacks.cs.html#0acd6a6393524657">ServerObject</a> = <span class="r28 r">server</span>;
                    
                    <a href="../../bcldebug.cs.html#e30488e330156f1b" class="t">BCLDebug</a>.<a href="../../bcldebug.cs.html#236a609eef21dbb5">Assert</a>((<span class="r28 r">server</span>!=<b>null</b>)==(!<a href="#598eece71f716b28">_bStatic</a>),
                                    <span class="s">&quot;Invalid state in stackbuilder sink?&quot;</span>);   
                                                
                    <a href="../../reflection/methodbase.cs.html#1383b72169c6b2ae" class="t">MethodBase</a> <span id="r30 rd" class="r30 r">mb</span> = <a href="#0a8e5ddb0b74d567">GetMethodBase</a>(<span class="r22 r">mcMsg</span>);
                    <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[] <span id="r31 rd" class="r31 r">outArgs</span> = <b>null</b>;
                    <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <span id="r32 rd" class="r32 r">ret</span> = <b>null</b>;                
                    <a href="remotingattributes.cs.html#bd139a1135e89a2e" class="t">RemotingMethodCachedData</a> <span id="r33 rd" class="r33 r">methodCache</span> = 
                        <a href="remotingservices.cs.html#0c192c4a05ae5a98" class="t">InternalRemotingServices</a>.<a href="remotingservices.cs.html#cabc9454b7caf89d">GetReflectionCachedData</a>(<span class="r30 r">mb</span>);                                
                    <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[] <span id="r34 rd" class="r34 r">args</span> = <a href="message.cs.html#575d97bdd0a2c995" class="t">Message</a>.<a href="message.cs.html#fee6cc27bdf5f8ba">CoerceArgs</a>(<span class="r22 r">mcMsg</span>, <span class="r33 r">methodCache</span>.<a href="remotingattributes.cs.html#a1c43aaf2f55df75">Parameters</a>);
 
                    <span class="r32 r">ret</span> = <a href="#7670282d17030ab4">PrivateProcessMessage</a>(<span class="r30 r">mb</span>.<a href="../../reflection/methodbase.cs.html#4d3bf777482b2f84">MethodHandle</a>,
                                                <span class="r34 r">args</span>,
                                                <span class="r28 r">server</span>,
                                                <b>out</b> <span class="r31 r">outArgs</span>);
                    <a href="#07adba7d0b87483a">CopyNonByrefOutArgsFromOriginalArgs</a>(<span class="r33 r">methodCache</span>, <span class="r34 r">args</span>, <b>ref</b> <span class="r31 r">outArgs</span>);
                                                           
                    <b>if</b>(<span class="r21 r">replySink</span> != <b>null</b>)
                    {     
                        <span class="c">// call context could be different then the one from before the call.</span>
                        <a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a> <span id="r35 rd" class="r35 r">latestCallContext</span> = <a href="../../threading/thread.cs.html#3980e012bae82e96" class="t">Thread</a>.<a href="../../threading/thread.cs.html#89653a7faafd4d23">CurrentThread</a>.<a href="../../threading/thread.cs.html#9d638a3b7cd843df">GetMutableExecutionContext</a>().<a href="../../threading/executioncontext.cs.html#2e09d198ef651abc">LogicalCallContext</a>;
                        
                        <b>if</b> (<span class="r35 r">latestCallContext</span> != <b>null</b>)
                        {
                            <span class="c">// Special case Principal since if might not be serializable before returning</span>
                            <span class="c">// ReturnMessage</span>
                            <span class="r35 r">latestCallContext</span>.<a href="callcontext.cs.html#3fe488520306671b">RemovePrincipalIfNotSerializable</a>();
                        }
                        
                        <span class="r24 r">retMessage</span> = <b>new</b> <a href="message.cs.html#9a5b84b2ab0d35ed" class="t">ReturnMessage</a>(
                                            <span class="r32 r">ret</span>, 
                                            <span class="r31 r">outArgs</span>, 
                                            (<span class="r31 r">outArgs</span> == <b>null</b> ? 0 : <span class="r31 r">outArgs</span>.<a href="../../array.cs.html#42e9b7616956cf94">Length</a>), 
                                            <span class="r35 r">latestCallContext</span>, 
                                            <span class="r22 r">mcMsg</span>);
 
                        <span class="c">// retrieve outgoing response headers</span>
                        <span class="r35 r">latestCallContext</span>.<a href="callcontext.cs.html#6ed00a6a8f181a23">PropagateOutgoingHeadersToMessage</a>(<span class="r24 r">retMessage</span>);
        
                    }
                } 
                <b>catch</b> (<a href="../../exception.cs.html#f092fb2b893a0162" class="t">Exception</a> <span id="r36 rd" class="r36 r">e</span>)
                {
                    <b>if</b>(<span class="r21 r">replySink</span> != <b>null</b>)
                    {
                        <span class="r24 r">retMessage</span> = <b>new</b> <a href="message.cs.html#b3ea8b70726ff28d" class="t">ReturnMessage</a>(<span class="r36 r">e</span>, <span class="r22 r">mcMsg</span>);
                        ((<a href="message.cs.html#967c76cf26b767ba" class="t">ReturnMessage</a>)<span class="r24 r">retMessage</span>).<a href="message.cs.html#4fa4d844eba8e355">SetLogicalCallContext</a>(
                                (<a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a>)
                                    <span class="r22 r">mcMsg</span>.<a href="imessage.cs.html#ec512e7e34a9f4f8">Properties</a><a href="../../collections/idictionary.cs.html#121995d2df15485a">[</a><a href="message.cs.html#575d97bdd0a2c995" class="t">Message</a>.<a href="message.cs.html#3b58f19bd46659cb">CallContextKey</a>]);
 
                    }
                }
                <b>finally</b>
                {
                    <b>if</b> (<span class="r21 r">replySink</span> != <b>null</b>)
                    {
                        <span class="c">// Call the reply sink without catching the exceptions</span>
                        <span class="c">// in it. In v2.0 any exceptions in the callback for example</span>
                        <span class="c">// would probably bring down the process</span>
                        <span class="r21 r">replySink</span>.<a href="imessagesink.cs.html#53fac414b21069ef">SyncProcessMessage</a>(<span class="r24 r">retMessage</span>);
                    }
                }
            }
            <b>finally</b> {
                <span class="c">// restore the call context on the thread</span>
                <b>if</b> (<span class="r26 r">isCallContextSet</span>)
                    <a href="callcontext.cs.html#f3ccc254455c175e" class="t">CallContext</a>.<a href="callcontext.cs.html#bfba16cc826cb8e4">SetLogicalCallContext</a>(<span class="r25 r">oldCallCtx</span>);
            }
 
            <b>return</b> <span class="r23 r">retCtrl</span>; 
        } <span class="c">// AsyncProcessMessage</span>
 
        <b>public</b> <a href="imessagesink.cs.html#e7887b7c8d4e9e16" class="t">IMessageSink</a> <a id="7bc868faddec7dce" href="../../../R/7bc868faddec7dce.html" target="n" data-glyph="102,1">NextSink</a>
        {
            [System.Security.<a href="../../security/attributes.cs.html#29a3d687a50338b1" class="t">SecurityCritical</a>]  <span class="c">// auto-generated</span>
            <b>get</b>
            {
                <span class="c">// there is no nextSink for the StackBuilderSink</span>
                <b>return null</b>;
            }
        }
 
        <span class="c">// This check if the call-site on the TP is in our own AD</span>
        <span class="c">// It also handles the special case where the TP is on </span>
        <span class="c">// a well-known object and we cannot do stack-blting</span>
        [System.Security.<a href="../../security/attributes.cs.html#29a3d687a50338b1" class="t">SecurityCritical</a>]  <span class="c">// auto-generated</span>
        <b>internal bool</b> <a id="0c0479d44f8ec202" href="../../../R/0c0479d44f8ec202.html" target="n" data-glyph="74,1">IsOKToStackBlt</a>(<a href="imethodmessage.cs.html#2b74445d3983df1c" class="t">IMethodMessage</a> <span id="r37 rd" class="r37 r">mcMsg</span>, <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <span id="r38 rd" class="r38 r">server</span>)
        {
            <b>bool</b> <span id="r39 rd" class="r39 r">bOK</span> = <b>false</b>;
            <a href="message.cs.html#575d97bdd0a2c995" class="t">Message</a> <span id="r40 rd" class="r40 r">msg</span> = <span class="r37 r">mcMsg</span> <b>as</b> <a href="message.cs.html#575d97bdd0a2c995" class="t">Message</a>;
            <b>if</b>(<b>null</b> != <span class="r40 r">msg</span>)
            {
                <a href="iinternalmessage.cs.html#4de6e48bee2aca81" class="t">IInternalMessage</a> <span id="r41 rd" class="r41 r">iiMsg</span> = (<a href="iinternalmessage.cs.html#4de6e48bee2aca81" class="t">IInternalMessage</a>) <span class="r40 r">msg</span>;
 
                <span class="c">// If there is a frame in the message we can always</span>
                <span class="c">// Blt it (provided it is not a proxy to a well-known</span>
                <span class="c">// object in our own appDomain)!</span>
                <span class="c">// The GetThisPtr == server test allows for people to wrap</span>
                <span class="c">// our proxy with their own interception .. in that case</span>
                <span class="c">// we should not blt the stack.</span>
                <b>if</b> (<span class="r40 r">msg</span>.<a href="message.cs.html#43493bb49c728af1">GetFramePtr</a>() != <a href="../../intptr.cs.html#d99bf6ad49979009" class="t">IntPtr</a>.<a href="../../intptr.cs.html#d46202ed9b6005b2">Zero</a>
                    &amp;&amp; <span class="r40 r">msg</span>.<a href="message.cs.html#6f84a334503e4c16">GetThisPtr</a>() == <span class="r38 r">server</span>
                    &amp;&amp; 
                    (   <span class="r41 r">iiMsg</span>.<a href="iinternalmessage.cs.html#ccc80c1f6a0c0fca">IdentityObject</a> == <b>null</b> ||
                        (  <span class="r41 r">iiMsg</span>.<a href="iinternalmessage.cs.html#ccc80c1f6a0c0fca">IdentityObject</a> != <b>null</b> 
                            &amp;&amp; <span class="r41 r">iiMsg</span>.<a href="iinternalmessage.cs.html#ccc80c1f6a0c0fca">IdentityObject</a> == <span class="r41 r">iiMsg</span>.<a href="iinternalmessage.cs.html#ed673c47c0bd7a44">ServerIdentityObject</a>
                        )
                    )
                )
                {
                    <span class="r39 r">bOK</span> = <b>true</b>;
                }
            }
 
            <b>return</b> <span class="r39 r">bOK</span>;
        }
        
        [System.Security.<a href="../../security/attributes.cs.html#29a3d687a50338b1" class="t">SecurityCritical</a>]  <span class="c">// auto-generated</span>
        <b>private static</b> <a href="../../reflection/methodbase.cs.html#1383b72169c6b2ae" class="t">MethodBase</a> <a id="0a8e5ddb0b74d567" href="../../../R/0a8e5ddb0b74d567.html" target="n" data-glyph="76,1">GetMethodBase</a>(<a href="imethodmessage.cs.html#2b74445d3983df1c" class="t">IMethodMessage</a> <span id="r42 rd" class="r42 r">msg</span>)
        {
            <a href="../../reflection/methodbase.cs.html#1383b72169c6b2ae" class="t">MethodBase</a> <span id="r43 rd" class="r43 r">mb</span> = <span class="r42 r">msg</span>.<a href="imethodmessage.cs.html#8364053c60dceaa1">MethodBase</a>;
            <b>if</b>(<b>null</b> == <span class="r43 r">mb</span>)      
            {
                <a href="../../bcldebug.cs.html#e30488e330156f1b" class="t">BCLDebug</a>.<a href="../../bcldebug.cs.html#648c37aa6a376eb7">Trace</a>(<span class="s">&quot;REMOTE&quot;</span>, <span class="s">&quot;Method missing w/name &quot;</span>, <span class="r42 r">msg</span>.<a href="imethodmessage.cs.html#101886858c343759">MethodName</a>);
                    <b>throw</b> <b>new</b> <a href="remotingexception.cs.html#048c5f1a0d868305" class="t">RemotingException</a>(
                        <a href="../../string.cs.html#8281103e6f23cb5c" class="t">String</a>.<a href="../../string.cs.html#9726f19207b91186">Format</a>(
                            <a href="../../globalization/cultureinfo.cs.html#e319c6636909012f" class="t">CultureInfo</a>.<a href="../../globalization/cultureinfo.cs.html#1f5907384ac6bb55">CurrentCulture</a>, <a href="../../environment.cs.html#7d2f1469d916fc63" class="t">Environment</a>.<a href="../../environment.cs.html#cc89c53dab5e83c0">GetResourceString</a>(
                                <span class="s">&quot;Remoting_Message_MethodMissing&quot;</span>),
                            <span class="r42 r">msg</span>.<a href="imethodmessage.cs.html#101886858c343759">MethodName</a>,
                            <span class="r42 r">msg</span>.<a href="imethodmessage.cs.html#90c46893ce88a19d">TypeName</a>));
            }
                    
            <b>return</b> <span class="r43 r">mb</span>;
        }
 
        [System.Security.<a href="../../security/attributes.cs.html#29a3d687a50338b1" class="t">SecurityCritical</a>]  <span class="c">// auto-generated</span>
        <b>private static void</b> <a id="109e12650870518e" href="../../../R/109e12650870518e.html" target="n" data-glyph="76,1">VerifyIsOkToCallMethod</a>(<a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <span id="r44 rd" class="r44 r">server</span>, <a href="imethodmessage.cs.html#2b74445d3983df1c" class="t">IMethodMessage</a> <span id="r45 rd" class="r45 r">msg</span>)
        {
            <b>bool</b> <span id="r46 rd" class="r46 r">bTypeChecked</span> = <b>false</b>;
            <a href="../../marshalbyrefobject.cs.html#8ec9f4cbed5b7726" class="t">MarshalByRefObject</a> <span id="r47 rd" class="r47 r">mbr</span> = <span class="r44 r">server</span> <b>as</b> <a href="../../marshalbyrefobject.cs.html#8ec9f4cbed5b7726" class="t">MarshalByRefObject</a>;
            <b>if</b> (<span class="r47 r">mbr</span> != <b>null</b>)
            {
                <b>bool</b> <span id="r48 rd" class="r48 r">fServer</span>;
                <a href="identity.cs.html#4eaa43cd9142e366" class="t">Identity</a> <span id="r49 rd" class="r49 r">id</span> = <a href="../../marshalbyrefobject.cs.html#8ec9f4cbed5b7726" class="t">MarshalByRefObject</a>.<a href="../../marshalbyrefobject.cs.html#bd88021f104b3529">GetIdentity</a>(<span class="r47 r">mbr</span>, <b>out</b> <span class="r48 r">fServer</span>);
                <b>if</b> (<span class="r49 r">id</span> != <b>null</b>)
                {
                    <a href="serveridentity.cs.html#ed625aa5ef5dbdd2" class="t">ServerIdentity</a> <span id="r50 rd" class="r50 r">srvId</span> = <span class="r49 r">id</span> <b>as</b> <a href="serveridentity.cs.html#ed625aa5ef5dbdd2" class="t">ServerIdentity</a>;
                    <b>if</b> ((<span class="r50 r">srvId</span> != <b>null</b>) &amp;&amp; <span class="r50 r">srvId</span>.<a href="serveridentity.cs.html#25fe400fe91db84b">MarshaledAsSpecificType</a>)
                    {
                        <a href="../../type.cs.html#3d00eeab9feb80f3" class="t">Type</a> <span id="r51 rd" class="r51 r">srvType</span> = <span class="r50 r">srvId</span>.<a href="serveridentity.cs.html#199f44debbcd112e">ServerType</a>;
                        <b>if</b> (<span class="r51 r">srvType</span> != <b>null</b>)
                        {
                            <a href="../../reflection/methodbase.cs.html#1383b72169c6b2ae" class="t">MethodBase</a> <span id="r52 rd" class="r52 r">mb</span> = <a href="#0a8e5ddb0b74d567">GetMethodBase</a>(<span class="r45 r">msg</span>);
                            <a href="../../rttype.cs.html#0d48ca51b2d2f8ed" class="t">RuntimeType</a> <span id="r53 rd" class="r53 r">declaringType</span> = (<a href="../../rttype.cs.html#0d48ca51b2d2f8ed" class="t">RuntimeType</a>)<span class="r52 r">mb</span>.<a href="../../reflection/memberinfo.cs.html#3eb1391de297c1a8">DeclaringType</a>;
                        
                            <span class="c">// make sure that srvType is not more restrictive than method base</span>
                            <span class="c">// (i.e. someone marshaled with a specific type or interface exposed)</span>
                            <b>if</b> ((<span class="r53 r">declaringType</span> != <span class="r51 r">srvType</span>) &amp;&amp;
                                !<span class="r53 r">declaringType</span>.<a href="../../rttype.cs.html#8deb9f60b3a9b569">IsAssignableFrom</a>(<span class="r51 r">srvType</span>))
                            {
                                <b>throw</b> <b>new</b> <a href="remotingexception.cs.html#048c5f1a0d868305" class="t">RemotingException</a>(
                                    <a href="../../string.cs.html#8281103e6f23cb5c" class="t">String</a>.<a href="../../string.cs.html#9726f19207b91186">Format</a>(
                                        <a href="../../globalization/cultureinfo.cs.html#e319c6636909012f" class="t">CultureInfo</a>.<a href="../../globalization/cultureinfo.cs.html#1f5907384ac6bb55">CurrentCulture</a>, <a href="../../environment.cs.html#7d2f1469d916fc63" class="t">Environment</a>.<a href="../../environment.cs.html#cc89c53dab5e83c0">GetResourceString</a>(<span class="s">&quot;Remoting_InvalidCallingType&quot;</span>),
                                        <span class="r52 r">mb</span>.<a href="../../reflection/memberinfo.cs.html#3eb1391de297c1a8">DeclaringType</a>.<a href="../../type.cs.html#976443bb39dc37cd">FullName</a>, <span class="r51 r">srvType</span>.<a href="../../type.cs.html#976443bb39dc37cd">FullName</a>));
                                    
                            }
                            <span class="c">// Set flag so we don&#39;t repeat this work below.</span>
                            <b>if</b> (<span class="r53 r">declaringType</span>.<a href="../../type.cs.html#d7e06d26feea45c5">IsInterface</a>)
                            {
                                <a href="#b4f7d1cdce7698a7">VerifyNotIRemoteDispatch</a>(<span class="r53 r">declaringType</span>);
                            }  
                            <span class="r46 r">bTypeChecked</span> = <b>true</b>;
                        }
                    }
                }
 
                <span class="c">// We must always verify that the type corresponding to </span>
                <span class="c">// the method being invoked is compatible with the real server </span>
                <span class="c">// type.</span>
                <b>if</b> (!<span class="r46 r">bTypeChecked</span>)
                {
                    <a href="../../reflection/methodbase.cs.html#1383b72169c6b2ae" class="t">MethodBase</a> <span id="r54 rd" class="r54 r">mb</span> = <a href="#0a8e5ddb0b74d567">GetMethodBase</a>(<span class="r45 r">msg</span>); 
                    <a href="../../rttype.cs.html#0d48ca51b2d2f8ed" class="t">RuntimeType</a> <span id="r55 rd" class="r55 r">reflectedType</span> = (<a href="../../rttype.cs.html#0d48ca51b2d2f8ed" class="t">RuntimeType</a>)<span class="r54 r">mb</span>.<a href="../../reflection/memberinfo.cs.html#212afcb9b0002edf">ReflectedType</a>;
                    <b>if</b> (!<span class="r55 r">reflectedType</span>.<a href="../../type.cs.html#d7e06d26feea45c5">IsInterface</a>)
                    {
                        <b>if</b> (!<span class="r55 r">reflectedType</span>.<a href="../../rttype.cs.html#11e2cc8ec5607523">IsInstanceOfType</a>(<span class="r47 r">mbr</span>))
                        {
                            <b>throw</b> <b>new</b> <a href="remotingexception.cs.html#048c5f1a0d868305" class="t">RemotingException</a>(
                                <a href="../../string.cs.html#8281103e6f23cb5c" class="t">String</a>.<a href="../../string.cs.html#9726f19207b91186">Format</a>(
                                    <a href="../../globalization/cultureinfo.cs.html#e319c6636909012f" class="t">CultureInfo</a>.<a href="../../globalization/cultureinfo.cs.html#1f5907384ac6bb55">CurrentCulture</a>, <a href="../../environment.cs.html#7d2f1469d916fc63" class="t">Environment</a>.<a href="../../environment.cs.html#cc89c53dab5e83c0">GetResourceString</a>(<span class="s">&quot;Remoting_InvalidCallingType&quot;</span>),
                                    <span class="r55 r">reflectedType</span>.<a href="../../rttype.cs.html#bef0a399dd5bd16c">FullName</a>, 
                                    <span class="r47 r">mbr</span>.<a href="../../object.cs.html#4d73eb225aef8a61">GetType</a>().<a href="../../type.cs.html#976443bb39dc37cd">FullName</a>));
                        }
                    }
                    <span class="c">// This code prohibits calls made to System.EnterpriseServices.IRemoteDispatch</span>
                    <span class="c">// so that remote call cannot bypass lowFilterLevel logic in the serializers.</span>
                    <span class="c">// This special casing should be removed in the future</span>
                    <b>else</b>
                    {
                        <a href="#b4f7d1cdce7698a7">VerifyNotIRemoteDispatch</a>(<span class="r55 r">reflectedType</span>);
                    }
                }
            }            
 
        } <span class="c">// VerifyIsOkToCallMethod</span>
 
        <span class="c">// This code prohibits calls made to System.EnterpriseServices.IRemoteDispatch</span>
        <span class="c">// so that remote call cannot bypass lowFilterLevel logic in the serializers.</span>
        <span class="c">// This special casing should be removed in the future</span>
        <span class="c">// Check whether we are calling IRemoteDispatch</span>
        [System.Security.<a href="../../security/attributes.cs.html#29a3d687a50338b1" class="t">SecurityCritical</a>]  <span class="c">// auto-generated</span>
        <b>private static void</b> <a id="b4f7d1cdce7698a7" href="../../../R/b4f7d1cdce7698a7.html" target="n" data-glyph="76,1">VerifyNotIRemoteDispatch</a>(<a href="../../rttype.cs.html#0d48ca51b2d2f8ed" class="t">RuntimeType</a> <span id="r56 rd" class="r56 r">reflectedType</span>)
        {
            <b>if</b>(<span class="r56 r">reflectedType</span>.<a href="../../rttype.cs.html#bef0a399dd5bd16c">FullName</a>.<a href="../../string.cs.html#31b307b02a3bd6b9">Equals</a>(<a href="#ae2258b06978f241">sIRemoteDispatch</a>) &amp;&amp; 
               <span class="r56 r">reflectedType</span>.<a href="../../rttype.cs.html#561804f283085347">GetRuntimeAssembly</a>().<a href="../../reflection/assembly.cs.html#e919a065db57bf2b">GetSimpleName</a>().<a href="../../string.cs.html#31b307b02a3bd6b9">Equals</a>(<a href="#21c8fb394024fd4c">sIRemoteDispatchAssembly</a>))
            {
                <b>throw</b> <b>new</b> <a href="remotingexception.cs.html#048c5f1a0d868305" class="t">RemotingException</a>(
                    <a href="../../environment.cs.html#7d2f1469d916fc63" class="t">Environment</a>.<a href="../../environment.cs.html#cc89c53dab5e83c0">GetResourceString</a>(<span class="s">&quot;Remoting_CantInvokeIRemoteDispatch&quot;</span>));
            }
        }
 
        <span class="c">// copies references of non-byref [In, Out] args from the input args to</span>
        <span class="c">//   the output args array.</span>
        <b>internal void</b> <a id="07adba7d0b87483a" href="../../../R/07adba7d0b87483a.html" target="n" data-glyph="74,1">CopyNonByrefOutArgsFromOriginalArgs</a>(<a href="remotingattributes.cs.html#bd139a1135e89a2e" class="t">RemotingMethodCachedData</a> <span id="r57 rd" class="r57 r">methodCache</span>,
                                                         <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[] <span id="r58 rd" class="r58 r">args</span>,
                                                         <b>ref</b> <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[] <span id="r59 rd" class="r59 r">marshalResponseArgs</span>)
        {            
            <b>int</b>[] <span id="r60 rd" class="r60 r">map</span> = <span class="r57 r">methodCache</span>.<a href="remotingattributes.cs.html#defaedcba6679038">NonRefOutArgMap</a>;
            <b>if</b> (<span class="r60 r">map</span>.<a href="../../array.cs.html#42e9b7616956cf94">Length</a> &gt; 0)
            {
                <b>if</b> (<span class="r59 r">marshalResponseArgs</span> == <b>null</b>)
                    <span class="r59 r">marshalResponseArgs</span> = <b>new</b> <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[<span class="r57 r">methodCache</span>.<a href="remotingattributes.cs.html#a1c43aaf2f55df75">Parameters</a>.<a href="../../array.cs.html#42e9b7616956cf94">Length</a>];
                
                <b>foreach</b> (<b>int</b> <span id="r61 rd" class="r61 r">pos</span> <b>in</b> <span class="r60 r">map</span>)
                {
                    <span class="r59 r">marshalResponseArgs</span>[<span class="r61 r">pos</span>] = <span class="r58 r">args</span>[<span class="r61 r">pos</span>];
                }
            }
        }
 
 
        <span class="c">// For the incoming call, we sometimes need to preserve the thread principal from</span>
        <span class="c">//   the executing thread, instead of blindly bashing it with the one from the message.</span>
        <span class="c">//   For instance, in cross process calls, the principal will always be null</span>
        <span class="c">//   in the incoming message. However, when we are hosted in ASP.Net, ASP.Net will handle</span>
        <span class="c">//   authentication and set up the thread principal. We should dispatch the call</span>
        <span class="c">//   using the identity that it set up.</span>
        [System.Security.<a href="../../security/attributes.cs.html#29a3d687a50338b1" class="t">SecurityCritical</a>]  <span class="c">// auto-generated</span>
        <b>internal static void</b> <a id="880d9bc9ce8d576c" href="../../../R/880d9bc9ce8d576c.html" target="n" data-glyph="74,1">PreserveThreadPrincipalIfNecessary</a>(
            <a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a> <span id="r62 rd" class="r62 r">messageCallContext</span>, 
            <a href="callcontext.cs.html#a7e5c6ec2bab3b61" class="t">LogicalCallContext</a> <span id="r63 rd" class="r63 r">threadCallContext</span>)
        {
            <a href="../../bcldebug.cs.html#e30488e330156f1b" class="t">BCLDebug</a>.<a href="../../bcldebug.cs.html#236a609eef21dbb5">Assert</a>(<span class="r62 r">messageCallContext</span> != <b>null</b>, <span class="s">&quot;message should always have a call context&quot;</span>);
 
            <b>if</b> (<span class="r63 r">threadCallContext</span> != <b>null</b>)
            {
                <b>if</b> (<span class="r62 r">messageCallContext</span>.<a href="callcontext.cs.html#4df56e9b5d4aa8ba">Principal</a> == <b>null</b>)
                {                
                    <a href="../../security/principal/iprincipal.cs.html#40fe672fdd6dae6b" class="t">IPrincipal</a> <span id="r64 rd" class="r64 r">currentPrincipal</span> = <span class="r63 r">threadCallContext</span>.<a href="callcontext.cs.html#4df56e9b5d4aa8ba">Principal</a>;
                    <b>if</b> (<span class="r64 r">currentPrincipal</span> != <b>null</b>)
                    {
                        <span class="r62 r">messageCallContext</span>.<a href="callcontext.cs.html#4df56e9b5d4aa8ba">Principal</a> = <span class="r64 r">currentPrincipal</span>;
                    }
                }
            }
        } <span class="c">// PreserveThreadPrincipalIfNecessary</span>
 
 
        <b>internal</b> <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <a id="a86e492cead2606a" href="../../../R/a86e492cead2606a.html" target="n" data-glyph="104,1">ServerObject</a>
        {
            <b>get</b> { <b>return</b> <a href="#c74d683002f4447b">_server</a>; }
        }
        
        
        <span class="c">//+============================================================</span>
        <span class="c">//</span>
        <span class="c">// Method:     PrivateProcessMessage, public</span>
        <span class="c">//</span>
        <span class="c">// Synopsis:   does the actual work of building the stack, </span>
        <span class="c">//             finding the correct code address and calling it.</span>
        <span class="c">//</span>
        <span class="c">// History:    06-May-1999  &lt;EMAIL&gt;MattSmit&lt;/EMAIL&gt;   Created</span>
        <span class="c">//-============================================================</span>
        [System.Security.<a href="../../security/attributes.cs.html#29a3d687a50338b1" class="t">SecurityCritical</a>]  <span class="c">// auto-generated</span>
        [<a href="../versioning/resourceattributes.cs.html#b7b54a119d25318b" class="t">ResourceExposure</a>(<a href="../versioning/resourceattributes.cs.html#49319f7427bafe9c" class="t">ResourceScope</a>.<a href="../versioning/resourceattributes.cs.html#e9a2a97c9c60e6bf">None</a>)]
        [<a href="../compilerservices/methodimplattribute.cs.html#b2f5af2558f436d5" class="t">MethodImplAttribute</a>(<a href="../compilerservices/methodimplattribute.cs.html#4159f5c528de6ee8" class="t">MethodImplOptions</a>.<a href="../compilerservices/methodimplattribute.cs.html#04c66f1bc88dd8d0">InternalCall</a>)]
        <b>private extern</b> <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <a id="382a473dedb2c5d9" href="../../../R/382a473dedb2c5d9.html" target="n" data-glyph="76,1">_PrivateProcessMessage</a>(
            <a href="../../intptr.cs.html#d99bf6ad49979009" class="t">IntPtr</a> <span id="r65 rd" class="r65 r">md</span>, <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[] <span id="r66 rd" class="r66 r">args</span>, <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <span id="r67 rd" class="r67 r">server</span>,
            <b>out</b> <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[] <span id="r68 rd" class="r68 r">outArgs</span>);
        [System.Security.<a href="../../security/attributes.cs.html#29a3d687a50338b1" class="t">SecurityCritical</a>]  <span class="c">// auto-generated</span>
        <b>public</b> <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>  <a id="7670282d17030ab4" href="../../../R/7670282d17030ab4.html" target="n" data-glyph="72,1">PrivateProcessMessage</a>(
            <a href="../../runtimehandles.cs.html#a6494e59afc3e504" class="t">RuntimeMethodHandle</a> <span id="r69 rd" class="r69 r">md</span>, <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[] <span id="r70 rd" class="r70 r">args</span>, <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <span id="r71 rd" class="r71 r">server</span>,
            <b>out</b> <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a>[] <span id="r72 rd" class="r72 r">outArgs</span>)
        {
            <b>return</b> <a href="#382a473dedb2c5d9">_PrivateProcessMessage</a>(<span class="r69 r">md</span>.<a href="../../runtimehandles.cs.html#05e59d7baa6e0e01">Value</a>, <span class="r70 r">args</span>, <span class="r71 r">server</span>, <b>out</b> <span class="r72 r">outArgs</span>);
        }
 
        <b>private</b> <a href="../../object.cs.html#d9262ceecc1719ab" class="t">Object</a> <a id="c74d683002f4447b" href="../../../R/c74d683002f4447b.html" target="n" data-glyph="46,1">_server</a>;              <span class="c">// target object</span>
        <b>private static string</b> <a id="ae2258b06978f241" href="../../../R/ae2258b06978f241.html" target="n" data-glyph="46,1">sIRemoteDispatch</a> = <span class="s">&quot;System.EnterpriseServices.IRemoteDispatch&quot;</span>;
        <b>private static string</b> <a id="21c8fb394024fd4c" href="../../../R/21c8fb394024fd4c.html" target="n" data-glyph="46,1">sIRemoteDispatchAssembly</a> = <span class="s">&quot;System.EnterpriseServices&quot;</span>;
 
        <b>bool</b> <a id="598eece71f716b28" href="../../../R/598eece71f716b28.html" target="n" data-glyph="46,1">_bStatic</a>;
     }
}
 
</pre></td></tr></table></div></body></html>
