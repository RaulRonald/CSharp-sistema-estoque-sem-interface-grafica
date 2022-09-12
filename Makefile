
all:
	csc /t:module objetos.cs
	csc /addmodule:objetos.netmodule /t:module main.cs
	al main.netmodule objetos.netmodule /main:loja.Principal.Main /out:estoque.exe /target:exe
