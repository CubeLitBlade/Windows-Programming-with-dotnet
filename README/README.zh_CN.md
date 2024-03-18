# Windows Programming with dotnet

> **Want an alternate version in English? Click [here](../README.md) to go.**

## 目录
- [简介](#简介)
- [使用说明](#使用说明)
  - [文件结构](#文件结构)
  - [获取存储库](#获取存储库)
    - [使用 Git 克隆存储库](#使用-git-克隆存储库)
    - [使用 Visual Studio 克隆存储库](#使用-visual-studio-克隆存储库)
    - [直接下载 zip 文件](#直接下载-zip-文件)
- [环境](#环境)

## 简介
此存储库的课题来自湖北大学的“Windows 程序设计”课程的实验报告。在此，我公开了我对于这些经典问题的解决方案。如果您有一定的编程基础，并且也准备学习使用 C# 和 .NET Framework 进行 Windows 开发，这个存储库中的内容也许可以帮助您起步。存储库中的每个项目并不难，因此，请不要将它作为一种深度教程（因为实在学不到什么东西）。在此，我将尽可能使每个项目完美地达成要求，然而，由于我的水平实在有限，总会有无法完全解决的问题，我将会把这些问题留在注释中。如果您对这些问题有什么好的见解的话，欢迎提交**Pull request**。最后，祝我们共同进步。

## 使用说明
### 文件结构
每一个用序号标为 "X-X" 的文件夹都是一个独立的项目。在每个项目中都存在**Topic.md**来描述项目的目标。

## 获取存储库
### 使用 Git 克隆存储库
如果您安装了 **Git**，直接在**终端**中运行以下命令即可。 
```bash
git clone https://github.com/CubeLitBlade/Windows-Programming-with-dotnet.git
```

### 使用 Visual Studio 克隆存储库
如果您安装了 **Visual Studio**，请先**复制**以下链接。 
```bash
https://github.com/CubeLitBlade/Windows-Programming-with-dotnet.git
```
然后，运行 Visual Studio，单击欢迎页的“**克隆存储库(C)**”。将链接**粘贴**到“**存储库位置(R)**”，配置存储库的路径，然后单击“**克隆(C)**”

### 直接下载 zip 文件
如果您需要下载存储库的 zip 文件，单击存储库页面的“**<> Code**”，然后在弹出的菜单中选择“**Download ZIP**”。 

## 环境
在下列环境中，程序运行正常。
|项目        |环境                                  |
| :-------: | :----------------------------------: |
|操作系统    |Microsoft Windows 11                  |
|集成开发环境|Microsoft Visual Studio Community 2022|
|.NET       |.NET Framework 4.8                    |

*.NET Framework 很快将不再受支持。如果您使用 Visual Studio，您将可以将项目升级到更新的 .NET，详情参阅[.NET 升级助手概述](https://learn.microsoft.com/zh-cn/dotnet/core/porting/upgrade-assistant-overview?WT.mc_id=dotnet-35129-website)。*
