# ASP.NET CoreとVue.jsを使用したSPAアプリ作成

## 参考サイト
https://docs.microsoft.com/ja-jp/ef/core/get-started/netcore/new-db-sqlite

## 構成

|モジュール名|バージョン|
|:-|:-|
|ASP.NET Core|2.1.4|
|Node.js|9.4.0|
|Vue.js|2.3.4|
|SQLite|

その他、`package.json`参照

## 新規プロジェクト作成コマンド

1. .NET Core プロジェクト作成

```bash
dotnet new --install Microsoft.AspNetCore.SpaTemplates::*
dotnet new vue
```

2. Vue.jsセットアップ
```bash
npm install
```

### SQLite用モジュール追加

```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

以下の設定をcsprojに追加(バージョンは自分の環境に合わせる)

```xml
<ItemGroup>
  <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.1" />
</ItemGroup>
```

追加後、ビルド実行

### マイグレーション実行

Modelクラス作成後、以下のコマンドを実行  
※Modelクラスについては`Models.cs`参照

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

