DbEntry Tools
==========

简介
----------

这是 [DbEntry.Net](http://dbentry.codeplex.com/) 中的 Tools 部分的源代码。

以前，我不太想提供这个源代码，是因为不希望这个跟使用 DbEntry 无关的代码干扰用户，而且，真正实现功能的代码，都在 Leafing.CodeGen 里，这些 Tools，只是提供了一个 GUI 的外壳而已，真的想了解实现，还是应该看 Leafing.CodeGen 的代码。

不过，总还是有人提出想看 Tools 的源代码，想想还是提供出来好了，省得再多解释了。

依赖
----------

Tools 中的编辑器，使用的是 [SharpDevelop](http://www.icsharpcode.net/) 共享的 ICSharpCode.TextEditor。

而 Docking 使用的是 WeifenLuo.WinFormsUI.Docking 控件，这个我没找到原始站点，不过在网上可以搜到很多使用介绍。

Tools
----------

Tools 分为三个项目。

AssemblyNameGetter 是用来取 Assembly 的完全限定名的，这个在 DbEntry 的配置里有时需要用到。

SqlQuerier 是对所有 DbEntry 支持的数据库，提供执行 SQL 的界面，以及对于目标数据表，生成 DbEntry 的 Model。

TemplateBuilder 对于 WEB 程序，提供根据 Models 生成相应的页面模板。

编译
----------

写了一个 build.bat，它会创建一个 Tools 目录，编译，并把生成的文件放入 Tools 目录。

不过，运行它之前，需要 Visual Studio 的环境变量都设置好了。

注意
----------

要正确运行 SqlQuerier 和 TemplateBuilder，需要 Tools 目录下，有 Bin 目录，其中放置 DbEntry 的所有 exe, dll，config 等文件。

SqlQuerier 的配置是放在一个数据库中的，目前缺省使用的是 SQLite 的数据库，如果你使用 SQLite 的数据库有问题，也可以改成其它 DbEntry 支持的数据库，具体设置参考 DbEntry，这里就不多说了。
