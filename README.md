
# Tic Tac Toe C#

Projetinho simples desenvolvido no curso técnico em Desenvolvimento de Sistemas do Senac de Pindamonhangaba. O jogo utiliza objeto _sender_ para manipulação do objeto que chama o evento de forma mais eficiente.




## Como funciona?
## 🧩 Visão Geral

- Desenvolvido com **Windows Forms** (WinForms).
- Jogador vs Jogador local.
- Verificação automática de vitória ou empate.
- Botão para reiniciar a partida.

---

## 🖼️ Interface Gráfica

A interface é composta por:

- ✅ **9 botões** dispostos em uma grade 3x3 (representando o tabuleiro).
- 🧾 **Label ou TextBox** para mostrar mensagens ao jogador (turno atual, vencedor, empate).
- 🔁 **Botões extras** como "Reiniciar Jogo" e "Sair".

---

## 🧠 Funcionamento do Jogo

### 1. Turno do Jogador

- O jogador "X" começa.
- Ao clicar em uma célula:
  - A célula é preenchida com "X" ou "O", conforme o turno.
  - O botão é desativado.
  - O turno alterna para o outro jogador.

### 2. Verificação de Vitória

Após cada jogada, o sistema verifica as seguintes combinações:

- **Linhas:** (0,1,2), (3,4,5), (6,7,8)
- **Colunas:** (0,3,6), (1,4,7), (2,5,8)
- **Diagonais:** (0,4,8), (2,4,6)

Se houver uma combinação válida:
- O jogo exibe o vencedor.
- Os botões restantes são desativados.

### 3. Empate

- Se todas as casas forem preenchidas e não houver vencedor, o jogo declara empate.

---

## 🔄 Reinício

- O botão "Reiniciar" limpa o tabuleiro e reinicia o jogo com o jogador "X".
- Todas as variáveis e estados são resetados.