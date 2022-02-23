# DDE2S

Orbitron の DDE クライアントのサンプルです。開発環境は Visual Studio 2022 で
.NET 6 の C$ Form アプリケーションです。  
Orbitron から 衛星名・ダウンリンク周波数・アップリンク周波数・方位・仰角を取得して、
シリアルポートに接続された無線機にコマンドとして送信することができます。

■Orbitron コンフィグファイルの修正

DDE2S を Orbitron のコンフィグファイルに追加
Orbitron\Config\Setup.cfg をテキストエディタで開き[Drivers]の所に exe ファイルのフルパスを追記します。

[Drivers]  
DDE2S=C:\your\installation\firectory\DDE2S.exe

■Orbitron 起動
![](https://github.com/ngc6589/DDE2S/blob/master/images/DDE2S-pict1.PNG)

Orbitron を起動後
- 1 Rotar/Radio タブをクリック
- 2 Driver のプルダウンから DDE2S を選択
- 3 横の run ボタンをクリックすると起動

