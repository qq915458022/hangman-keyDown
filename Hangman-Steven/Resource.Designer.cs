﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangman_Steven {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Hangman_Steven.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 3
        ///1
        ///5
        ///2
        ///0
        ///0
        ///C:\Users\Administrator.USER-20150504BT\Desktop\Hangman-Steven\Hangman-Steven\bin\Debug\music\letterFailure.mp3
        ///C:\Users\Administrator.USER-20150504BT\Desktop\Hangman-Steven\Hangman-Steven\bin\Debug\music\letterSuccess.mp3
        ///C:\Users\Administrator.USER-20150504BT\Desktop\Hangman-Steven\Hangman-Steven\bin\Debug\music\loseGame.mp3
        ///C:\Users\Administrator.USER-20150504BT\Desktop\Hangman-Steven\Hangman-Steven\bin\Debug\music\gameWon.mp3
        ///0
        ///0
        ///160
        ///100
        ///100
        ///100
        ///200
        ///0
        ///0
        ///30
        ///255
        ///255
        ///0
        ///0
        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string configureFile {
            get {
                return ResourceManager.GetString("configureFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 0001# The philosophy of the school room in one generation will be the philosophy of government in the next. ~ Abraham Lincoln
        ///0002# You cannot escape the responsibility of tomorrow by evading it today. ~ Abraham Lincoln
        ///0003# All that I am, or hope to be, I owe to my angel mother. ~ Abraham Lincoln
        ///0004# Be sure you put your feet in the right place, then stand firm. ~ Abraham Lincoln
        ///0005# Learn from yesterday, live for today, hope for tomorrow. ~ Albert Einstein
        ///0006# If you can&apos;t explain it simply, you do [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string data {
            get {
                return ResourceManager.GetString("data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] gameWon {
            get {
                object obj = ResourceManager.GetObject("gameWon", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] letterFailure {
            get {
                object obj = ResourceManager.GetObject("letterFailure", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] letterSuccess {
            get {
                object obj = ResourceManager.GetObject("letterSuccess", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] loseGame {
            get {
                object obj = ResourceManager.GetObject("loseGame", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
