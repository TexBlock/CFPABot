﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CFPABot.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Locale {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Locale() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CFPABot.Resources.Locale", typeof(Locale).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 警告：你所提交的目标分支不是 main 分支，这在 99% 的情况下都是你的问题。请 close 此 PR 并重新提交。.
        /// </summary>
        public static string Artifacts_BranchNotMain {
            get {
                return ResourceManager.GetString("Artifacts.BranchNotMain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 更新编译 artifacts 出错: {0}.
        /// </summary>
        public static string Artifacts_Error {
            get {
                return ResourceManager.GetString("Artifacts.Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to :floppy_disk: 你可以在 [这里]({0}/pull/{1}/checks) 点击 PR Packer\&gt;Artifacts 下载基于此 PR 所打包的最新资源包。.
        /// </summary>
        public static string Artifacts_Hint {
            get {
                return ResourceManager.GetString("Artifacts.Hint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 暂时没有检测到 workflow..
        /// </summary>
        public static string Artifacts_NoWorkflowYet {
            get {
                return ResourceManager.GetString("Artifacts.NoWorkflowYet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 警告：你没有启用“维护者可修改 PR 文件”（Allow edits from maintainers）；这可能会对维护者造成不便，请在此页面右方勾选此选项。.
        /// </summary>
        public static string Artifacts_PREditDisabledWarning {
            get {
                return ResourceManager.GetString("Artifacts.PREditDisabledWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 检查出错: {0}.
        /// </summary>
        public static string Check_Error {
            get {
                return ResourceManager.GetString("Check.Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 获取 PR 中 {0}-{1} 的中文语言文件失败。如果你在提交或更新英文语言文件，请忽略此信息。.
        /// </summary>
        public static string Check_FileKey_FailedToDownloadCn {
            get {
                return ResourceManager.GetString("Check.FileKey.FailedToDownloadCn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ❌ 获取 PR 中 {0}-{1} 的英文语言文件失败。你可能没有提交此模组的英文语言文件。使用命令 `/update-en {2} {3}` 来获取模组语言文件。.
        /// </summary>
        public static string Check_FileKey_FailedToDownloadEn {
            get {
                return ResourceManager.GetString("Check.FileKey.FailedToDownloadEn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ 获取 {0} 的模组内语言文件失败。.
        /// </summary>
        public static string Check_FileKey_FailedToDownloadMod {
            get {
                return ResourceManager.GetString("Check.FileKey.FailedToDownloadMod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ 找到了多个 {0}-{1} 的模组内语言文件。将不进行模组语言文件检查。.
        /// </summary>
        public static string Check_FileKey_ModEnFile_Multiple {
            get {
                return ResourceManager.GetString("Check.FileKey.ModEnFile.Multiple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ 没有找到 {0}-{1} 的模组内语言文件。.
        /// </summary>
        public static string Check_FileKey_ModEnFile_NotFound {
            get {
                return ResourceManager.GetString("Check.FileKey.ModEnFile.NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 所涉及文件过多，将不进行检查。.
        /// </summary>
        public static string Check_General_ToManyFiles {
            get {
                return ResourceManager.GetString("Check.General.ToManyFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ {0}-{1} 的语言文件检查失败：{2}.
        /// </summary>
        public static string Check_Key_Error {
            get {
                return ResourceManager.GetString("Check.Key.Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ {0}-{1} 的中文文件为空。.
        /// </summary>
        public static string Check_Key_JsonCnFileEmpty {
            get {
                return ResourceManager.GetString("Check.Key.JsonCnFileEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ {0}-{1} 的英文文件为空。.
        /// </summary>
        public static string Check_Key_JsonEnFileEmpty {
            get {
                return ResourceManager.GetString("Check.Key.JsonEnFileEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ❌ {0}-{1} 的语言文件中有 JSON 语法错误：{2}.
        /// </summary>
        public static string Check_Key_JsonSyntaxError {
            get {
                return ResourceManager.GetString("Check.Key.JsonSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ {0}-{1} 的中文语言文件为空。.
        /// </summary>
        public static string Check_Key_LangCnFileEmpty {
            get {
                return ResourceManager.GetString("Check.Key.LangCnFileEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ {0}-{1} 的英文语言文件为空。.
        /// </summary>
        public static string Check_Key_LangEnFileEmpty {
            get {
                return ResourceManager.GetString("Check.Key.LangEnFileEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 警告：PR 中 {0}-{1} 的中英文语言文件不对应。.
        /// </summary>
        public static string Check_Key_NotCorrespond {
            get {
                return ResourceManager.GetString("Check.Key.NotCorrespond", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ {0}-{1} 语言文件验证通过。.
        /// </summary>
        public static string Check_Key_Success {
            get {
                return ResourceManager.GetString("Check.Key.Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ Mod Domain 验证失败：{0}.
        /// </summary>
        public static string Check_ModID_Error {
            get {
                return ResourceManager.GetString("Check.ModID.Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 警告：Mod Domain 验证不通过。文件 Mod Domain 为 `{0}`；而 PR 所提供的 Mod Domain 为 `{1}`。.
        /// </summary>
        public static string Check_ModID_Failed_1 {
            get {
                return ResourceManager.GetString("Check.ModID.Failed.1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 你可以使用命令 `/mv-recursive &quot;projects/{0}/assets/{1}/{2}/&quot; &quot;projects/{3}/assets/{4}/{5}/&quot;` 来移动目录。.
        /// </summary>
        public static string Check_ModID_Failed_2 {
            get {
                return ResourceManager.GetString("Check.ModID.Failed.2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ 无法找到 `{0}` 的 Mod Domain。这很可能是因为 CurseForge API 没有返回这个模组的数据。.
        /// </summary>
        public static string Check_ModID_ModIDNotFound {
            get {
                return ResourceManager.GetString("Check.ModID.ModIDNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 找不到模组: {0}-{1}。.
        /// </summary>
        public static string Check_ModID_ModNotFound {
            get {
                return ResourceManager.GetString("Check.ModID.ModNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ✔ `{0}` Mod Domain 验证通过。.
        /// </summary>
        public static string Check_ModID_Success {
            get {
                return ResourceManager.GetString("Check.ModID.Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ {0}-{1} 的语言文件检查失败：{2}.
        /// </summary>
        public static string Check_ModKey_Error {
            get {
                return ResourceManager.GetString("Check.ModKey.Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ❌ {0}-{1} 的语言文件中有 JSON 语法错误：{2}.
        /// </summary>
        public static string Check_ModKey_JsonSyntaxError {
            get {
                return ResourceManager.GetString("Check.ModKey.JsonSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 警告：PR 中 {0}-{1} 的英文语言文件与最新模组 `{2}` 内的英文语言文件不对应。自动获取的文件只能反映大多数情况，可能并不需要更新文件。如果你认为英文语言文件**确实**需要更新到**上面的版本**，可以使用命令 `/update-en {3} {4}` 来更新。.
        /// </summary>
        public static string Check_ModKey_NotCorrespond {
            get {
                return ResourceManager.GetString("Check.ModKey.NotCorrespond", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ {0}-{1} 模组内语言文件验证通过。.
        /// </summary>
        public static string Check_ModKey_Success {
            get {
                return ResourceManager.GetString("Check.ModKey.Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 更多报告可以在 [这里]({0}) 查看。 在 PR 更新时这里的检查也会自动更新。.
        /// </summary>
        public static string Check_Result {
            get {
                return ResourceManager.GetString("Check.Result", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 报告也可以在 [这里]({0}) 查看。在 PR 更新时这里的检查也会自动更新。.
        /// </summary>
        public static string Check_Result1 {
            get {
                return ResourceManager.GetString("Check.Result1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 上方的译名检测仅有参考价值，可能并没有实际错误。**请在修改前仔细斟酌！**.
        /// </summary>
        public static string Check_Translate_Hint {
            get {
                return ResourceManager.GetString("Check.Translate.Hint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ 注意：检测到可能的争议译名：`{0}`，{1}。例如行 `{2}`。.
        /// </summary>
        public static string Check_Translate_PossibleControversial {
            get {
                return ResourceManager.GetString("Check.Translate.PossibleControversial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ❌ 警告：检测到可能的错误译名：`{0}`，{1}。例如行 `{2}`。.
        /// </summary>
        public static string Check_Translate_PossibleWrong {
            get {
                return ResourceManager.GetString("Check.Translate.PossibleWrong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 警告：文件路径中含有大写字母。如 `{0}`。.
        /// </summary>
        public static string Check_UpperCaseWarning {
            get {
                return ResourceManager.GetString("Check.UpperCaseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 为了防止此命令被错误执行，此命令只有 @Cyl18 才能执行。
        ///.
        /// </summary>
        public static string Command_add_mapping_Rejected {
            get {
                return ResourceManager.GetString("Command.add-mapping.Rejected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 添加重定向 {0} -&gt; {1} 失败。提供的 slug 为 {2} 而 API 返回的为 {3}。.
        /// </summary>
        public static string Command_add_mapping_SlugMismatch {
            get {
                return ResourceManager.GetString("Command.add-mapping.SlugMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ 添加重定向 {0} -&gt; {1} 成功。请使用强制刷新来刷新数据。.
        /// </summary>
        public static string Command_add_mapping_Success {
            get {
                return ResourceManager.GetString("Command.add-mapping.Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 在执行命令时遇到了问题：{0}.
        /// </summary>
        public static string Command_general_Error {
            get {
                return ResourceManager.GetString("Command.general.Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 保护 main 分支，命令拒绝执行。.
        /// </summary>
        public static string Command_general_MainBranchProtected {
            get {
                return ResourceManager.GetString("Command.general.MainBranchProtected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 你是此 PR 的创建者，但是你的 PR 所指向的仓库的所有权并不属于你。由于可能会造成不可预知的错误，拒绝执行此命令。.
        /// </summary>
        public static string Command_General_OwnerPermissionDenied {
            get {
                return ResourceManager.GetString("Command.General.OwnerPermissionDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 你没有执行此命令的权限。.
        /// </summary>
        public static string Command_general_PermissionDenied {
            get {
                return ResourceManager.GetString("Command.general.PermissionDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 安全检查错误：你所操作的目录不在工作目录下。.
        /// </summary>
        public static string Command_mv_SecurityCheckFailure {
            get {
                return ResourceManager.GetString("Command.mv.SecurityCheckFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 指定的文件不存在。.
        /// </summary>
        public static string Command_sort_keys_FileNotExists {
            get {
                return ResourceManager.GetString("Command.sort-keys.FileNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 无法识别的文件。.
        /// </summary>
        public static string Command_sort_keys_FileNotRecognized {
            get {
                return ResourceManager.GetString("Command.sort-keys.FileNotRecognized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 更新失败：找到了多个语言文件。.
        /// </summary>
        public static string Command_update_en_MultipleLangFiles {
            get {
                return ResourceManager.GetString("Command.update-en.MultipleLangFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ℹ 更新语言文件完成；使用 {0} 中的语言文件。.
        /// </summary>
        public static string Command_update_en_Success {
            get {
                return ResourceManager.GetString("Command.update-en.Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 无法找到 {0} 的 CurseForge 项目名到 CurseForge ID 的映射。请检查此[链接](https://www.curseforge.com/minecraft/mc-mods/{1})是否可以正常打开，如果不能，或者网页被重定向，请修改你的文件路径。.
        /// </summary>
        public static string General_MapModIDToProjectID_Error_1 {
            get {
                return ResourceManager.GetString("General.MapModIDToProjectID.Error.1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 如果可以，请联系 [Cyl18](https://github.com/Cyl18) 解决。.
        /// </summary>
        public static string General_MapModIDToProjectID_Error_2 {
            get {
                return ResourceManager.GetString("General.MapModIDToProjectID.Error.2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 此外在项目名中检测到了大写字母，请调整为小写。.
        /// </summary>
        public static string General_MapModIDToProjectID_Error_3 {
            get {
                return ResourceManager.GetString("General.MapModIDToProjectID.Error.3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 命令 `/add-mapping {0} [CURSEFORGE_PROJECT_ID]` 或 `/mv &quot;projects/[GAME_VERSION]/assets/{1}/&quot; &quot;projects/[GAME_VERSION]/assets/[NEW_DIR]/&quot;`。.
        /// </summary>
        public static string General_MapModIDToProjectID_Error_4 {
            get {
                return ResourceManager.GetString("General.MapModIDToProjectID.Error.4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ⚠ 更新模组列表出错: {0}.
        /// </summary>
        public static string ModLink_Error {
            get {
                return ResourceManager.GetString("ModLink.Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 模组数量过多，将不显示模组链接。.
        /// </summary>
        public static string ModLink_TooManyMods {
            get {
                return ResourceManager.GetString("ModLink.TooManyMods", resourceCulture);
            }
        }
    }
}
