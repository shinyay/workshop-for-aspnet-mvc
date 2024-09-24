# GitHub Copilot Workshop for C#

## Description

## Demo/Hands-on
### Step 1: Ask for Project and Files

![Image](https://github.com/user-attachments/assets/8b6c0879-fd57-4641-b3ec-3a181a6df6a8)

```text
@workspace このプロジェクトの構成とそれぞれのファイルについて教えてください。
```

<details>
<summary>Step 1: Ask for Project and Files</summary>

### プロジェクト構成

```text
240926-workshop/
    .gitignore
    appsettings.Development.json
    appsettings.json
    bin/
        Debug/
    Controllers/
        HomeController.cs
    Models/
        ErrorViewModel.cs
    obj/
        Debug/
        project.assets.json
        project.nuget.cache
        workshop240926.csproj.nuget.dgspec.json
        workshop240926.csproj.nuget.g.props
        workshop240926.csproj.nuget.g.targets
    Program.cs
    Properties/
        launchSettings.json
    README.md
    Views/
        _ViewImports.cshtml
        _ViewStart.cshtml
        ...
    workshop240926.csproj
    wwwroot/
        ...
workspace.sln
```

### 各ファイルの説明

- **.gitignore**: Gitで管理しないファイルやディレクトリを指定するファイル。
- **appsettings.Development.json**: 開発環境用の設定ファイル。
- **appsettings.json**: 共通の設定ファイル。
- **bin/**: ビルド成果物が格納されるディレクトリ。
  - **Debug/**: デバッグビルドの成果物が格納されるディレクトリ。
- **Controllers/**: コントローラーが格納されるディレクトリ。
  - **HomeController.cs**: ホームページのコントローラー。例: [`HomeController`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2FControllers%2FHomeController.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22HomeController%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/Controllers/HomeController.cs")
- **Models/**: モデルが格納されるディレクトリ。
  - **ErrorViewModel.cs**: エラービューのモデル。例: [`ErrorViewModel`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2FModels%2FErrorViewModel.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22ErrorViewModel%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/Models/ErrorViewModel.cs")
- **obj/**: ビルド中間ファイルが格納されるディレクトリ。
  - **Debug/**: デバッグビルドの中間ファイルが格納されるディレクトリ。
  - **project.assets.json**: プロジェクトの依存関係が記載されたファイル。
  - **project.nuget.cache**: NuGetパッケージのキャッシュファイル。
  - **workshop240926.csproj.nuget.dgspec.json**: NuGetの依存関係仕様ファイル。
  - **workshop240926.csproj.nuget.g.props**: NuGetのプロパティファイル。
  - **workshop240926.csproj.nuget.g.targets**: NuGetのターゲットファイル。
- **Program.cs**: アプリケーションのエントリーポイント。例: [`Program`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2FProgram.cs%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22Program%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/Program.cs")
- **Properties/**: プロジェクトのプロパティが格納されるディレクトリ。
  - **launchSettings.json**: デバッグや実行時の設定ファイル。例: [`launchSettings.json`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2FProperties%2FlaunchSettings.json%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22launchSettings.json%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/Properties/launchSettings.json")
- **README.md**: プロジェクトの説明や使用方法が記載されたファイル。例: [`README.md`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2FREADME.md%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22README.md%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/README.md")
- **Views/**: ビューが格納されるディレクトリ。
  - **_ViewImports.cshtml**: ビューのインポート設定ファイル。
  - **_ViewStart.cshtml**: ビューの開始設定ファイル。
  - **Shared/**: 共有ビューが格納されるディレクトリ。
    - **Error.cshtml**: エラービュー。例: [`Error.cshtml`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2FViews%2FShared%2FError.cshtml%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22Error.cshtml%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/Views/Shared/Error.cshtml")
    - **_Layout.cshtml**: レイアウトビュー。例: [`_Layout.cshtml`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2FViews%2FShared%2F_Layout.cshtml%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22_Layout.cshtml%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/Views/Shared/_Layout.cshtml")
- **workshop240926.csproj**: プロジェクトファイル。
- **wwwroot/**: 静的ファイルが格納されるディレクトリ。
  - **lib/**: ライブラリが格納されるディレクトリ。
    - **jquery-validation-unobtrusive/**: jQueryのバリデーションライブラリ。
      - **jquery.validate.unobtrusive.min.js**: 圧縮版のJavaScriptファイル。例: [`jquery.validate.unobtrusive.min.js`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2Fwwwroot%2Flib%2Fjquery-validation-unobtrusive%2Fjquery.validate.unobtrusive.min.js%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22jquery.validate.unobtrusive.min.js%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js")
      - **jquery.validate.unobtrusive.js**: 非圧縮版のJavaScriptファイル。例: [`jquery.validate.unobtrusive.js`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2Fwwwroot%2Flib%2Fjquery-validation-unobtrusive%2Fjquery.validate.unobtrusive.js%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22jquery.validate.unobtrusive.js%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js")
      - **LICENSE.txt**: ライセンスファイル。例: [`LICENSE.txt`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2Fwwwroot%2Flib%2Fjquery-validation-unobtrusive%2FLICENSE.txt%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22LICENSE.txt%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt")
    - **jquery-validation/**: jQueryのバリデーションライブラリ。
      - **LICENSE.md**: ライセンスファイル。例: [`LICENSE.md`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2Fwwwroot%2Flib%2Fjquery-validation%2FLICENSE.md%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22LICENSE.md%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/wwwroot/lib/jquery-validation/LICENSE.md")
    - **jquery/**: jQueryライブラリ。
      - **LICENSE.txt**: ライセンスファイル。例: [`LICENSE.txt`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2Fwwwroot%2Flib%2Fjquery%2FLICENSE.txt%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22LICENSE.txt%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/wwwroot/lib/jquery/LICENSE.txt")
  - **js/**: JavaScriptファイルが格納されるディレクトリ。
    - **site.js**: カスタムJavaScriptファイル。例: [`site.js`](command:_github.copilot.openSymbolInFile?%5B%7B%22scheme%22%3A%22file%22%2C%22authority%22%3A%22%22%2C%22path%22%3A%22%2Fworkspace%2F240926-workshop%2Fwwwroot%2Fjs%2Fsite.js%22%2C%22query%22%3A%22%22%2C%22fragment%22%3A%22%22%7D%2C%22site.js%22%2C%22fa9830bb-3732-4475-87d0-80f65c6c0478%22%5D "/workspace/240926-workshop/wwwroot/js/site.js")
- **workspace.sln**: ソリューションファイル。複数のプロジェクトを管理するためのファイル。

</details>

### Step 2: Run the Project

![Image](https://github.com/user-attachments/assets/96303dd5-1145-46b8-aca3-9bcef3833f25)


```text
@terminal このASP.NET プロジェクトを起動するコマンドについて教えてください。
```


<details>
<summary>Step 2: Run the Project</summary>

```code
dotnet run --project {project_path}
```

- `{project_path}`: プロジェクトファイル (.csproj) のパス

![Image](https://github.com/user-attachments/assets/052b1e36-835f-4ed5-904c-c430f42a284d)
</details>

### Notes: Chat Participants

**Chat Participants** を使用して、プロンプトの範囲を特定のドメインに設定します。 Chat Participants を使用するには、チャット プロンプト ボックスに 「@」 と入力し、その後にChat Participants 名を入力します。 Chat Participants には次のものが含まれます。

|Participants|説明|
|---|---|
|@workspace|ワークスペース内のコードに関するコンテキストをスコープ対象に設定<br>「プロジェクトの構造」「コードの相互関係」や「デザインパターン」などについて Copilot に回答を求めるときに役立つ|
|@vscode|Visual Studio Code のコマンドと機能に関するコンテキストをスコープ対象に設定<br>VS Code のコマンドやカスタマイズに関する回答を求めるときに役立つ|
|@terminal|Visual Studio Code  のターミナルシェルとその内容をスコープ対象<br>ターミナルコマンドの作成やデバッグに関する回答を求めるときに役立つ|

### Step 3: Code Suggestion with Comment

![Image](https://github.com/user-attachments/assets/262cd3bf-aeb9-429f-8266-dec006c45663)

[HomeController.cs](Controllers/HomeController.cs) に追加しているコメントを参考に今日の日付を Home 画面に表示するようにコード修正をしてください。

![Image](https://github.com/user-attachments/assets/433a0598-9d3d-4301-80ca-489e2472f637)

#### (Optional) Step 3.1: Display the Current Date and Time

コメントとして記載したプロンプトを変更して現在日時を表示するようにコード修正をしてください。

![Image](https://github.com/user-attachments/assets/a62ec671-e00f-4eac-b6d8-505715f23eff)

#### (Optional) Step 3.2: Display the Current Date and Time in Japan Standard Time

プロンプトや GitHub Copilot チャットを使用して、現在日時を日本標準時で表示するようにコード修正をしてください。

![Image](https://github.com/user-attachments/assets/790e101b-1158-44e5-aa61-231449b45d3f)

#### Hint

コード提案に関するショートカットキー

|操作内容|ショートカットキー|
|---|---|
|提案を受け入れる|`Tab`|
|提案を拒否する|`Esc`|
|次の提案を表示する|`Alt` + `]`|
|前の提案を表示する|`Alt` + `[`|
|提案に示された単語毎に受け入れる|`Ctrl` + `→`|
|複数の提案を新しいタブに表示する|`Ctrl` + `Enter`|

GitHub Copilot チャットの表示に関するショートカットキー

|操作内容|ショートカットキー|
|---|---|
|チャット ビュー|`Ctrl` + `Alt` + `i`|
|クイックチャット|`Ctrl` + `Shift` + `i`|
|インラインチャット|`Ctrl` + `i`|

### Step 4: Code Suggestion wirh Copilot Chat

Git Hub Copilot チャットを使用して、画面のデザイン (CSS ファイル)を変更し、画面上にボタン（ダミーボタンでもよい）を追加するようにコード修正をしてください。

例： Microsoft 風な色合いのCSSに変更してください。

![Image](https://github.com/user-attachments/assets/c5954d31-b938-4b37-930f-fd7bbd2dfd89)

<details>
<summary>Step 4: Code Suggestion wirh Copilot Chat</summary>

![Image](https://github.com/user-attachments/assets/65d5a329-916b-49cc-9ff4-a4d0a34b328f)

```css
html {
  font-size: 14px;
}

@media (min-width: 768px) {
  html {
    font-size: 16px;
  }
}

.btn:focus, .btn:active:focus, .btn-link.nav-link:focus, .form-control:focus, .form-check-input:focus {
  box-shadow: 0 0 0 0.1rem white, 0 0 0 0.25rem #0078D4; /* Microsoft Blue */
}

html {
  position: relative;
  min-height: 100%;
}

body {
  margin-bottom: 60px;
  background-color: #F3F2F1; /* Microsoft Light Gray */
  color: #323130; /* Microsoft Dark Gray */
}

/* Additional styles for Microsoft look and feel */
.navbar {
  background-color: #0078D4; /* Microsoft Blue */
  color: white;
}

.navbar a {
  color: white;
}

.btn-primary {
  background-color: #0078D4; /* Microsoft Blue */
  border-color: #0078D4;
}

.btn-primary:hover {
  background-color: #005A9E; /* Darker Microsoft Blue */
  border-color: #005A9E;
}

.btn-secondary {
  background-color: #F3F2F1; /* Microsoft Light Gray */
  border-color: #F3F2F1;
  color: #323130; /* Microsoft Dark Gray */
}

.btn-secondary:hover {
  background-color: #E1DFDD; /* Darker Microsoft Light Gray */
  border-color: #E1DFDD;
}
```

![Image](https://github.com/user-attachments/assets/d68155a2-0d87-431b-8656-670313903ece)
</details>

## Features

- feature:1
- feature:2

## Requirement

## Usage

## Installation

## References

## Licence

Released under the [MIT license](https://gist.githubusercontent.com/shinyay/56e54ee4c0e22db8211e05e70a63247e/raw/f3ac65a05ed8c8ea70b653875ccac0c6dbc10ba1/LICENSE)

## Author

- github: <https://github.com/shinyay>
- twitter: <https://twitter.com/yanashin18618>
- mastodon: <https://mastodon.social/@yanashin>
