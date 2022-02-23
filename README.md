# DDE2S

Orbitron の DDE クライアントのサンプルです。開発環境は Visual Studio 2022 で
.NET 6 の C$ Form アプリケーションです。  
Orbitron から 衛星名・ダウンリンク周波数・アップリンク周波数・方位・仰角を取得して、
シリアルポートに接続された無線機にコマンドとして送信することができます。

■.NET 6.0 デスクトップランタイム Windows-x86 のインストール  
Microsoft のダウンロードサイトから .Net 6.0 ランタイムをダウンロードしインストールします。
https://dotnet.microsoft.com/ja-jp/download/dotnet/6.0  
![](https://github.com/ngc6589/DDE2S/blob/master/images/DDE2S-pict9.PNG)

Windows x86 版のランタイムをクリックするとダウンロードページが表示されます。
スクリーンショットでは .NET 6.0.2 と表示されていますが、新しいリリースがあると 6.0.3 などになっている場合があります。6.0.x を選択してください。

![](https://github.com/ngc6589/DDE2S/blob/master/images/DDE2S-pict8.PNG)
ダウンロードした windowsdesktop-runtime-6.0.2-win-x86.exe をダブルクリックしてランタイムをインストールしてください。

■DDE2S のインストール  
zip ファイルを展開して、任意の場所に設置してください。

■Orbitron コンフィグファイルの修正  
Orbitron をインストールしたフォルダに Config フォルダがあります。Setup.cfg をテキストエディタで開いて
DDE2Sの設定を追加します。

    [Drivers]  
    DDE2S=DDE2S.exe

もし、[Drivers] という記述がなければ上記2行を追加して下さい。{Drivers] があれんば、DDE2S=DDE2S.exe だけ追加。

■Orbitron 起動
![](https://github.com/ngc6589/DDE2S/blob/master/images/DDE2S-pict1.PNG)

Orbitron を起動後
- 1 Rotar/Radio タブをクリック
- 2 Driver のプルダウンから DDE2S を選択
- 3 横の run ボタンをクリックすると DDE2S.exe が見つからないと表示されます。
![](https://github.com/ngc6589/DDE2S/blob/master/images/DDE2S-pict10.PNG)
YES ボタンを押すとファイル選択ダイアログが表示されます。
![](https://github.com/ngc6589/DDE2S/blob/master/images/DDE2S-pict11.PNG)
DDE2S.exe 選択して開くボタンで Orbitron の設定ファイルが正しい状態に更新されます。




