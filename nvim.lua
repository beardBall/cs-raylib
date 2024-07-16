--require 'paths'


--print("hello from local nvim.lua")
vim.keymap.set({'n', 'v', 'i'}, "<C-b>","<cmd>w<CR><cmd>! ./run.sh<CR>")
vim.keymap.set({'n', 'v', 'i'}, "<C-s>","<cmd>w<CR>")

vim.keymap.set({'n', 'v', 'i'}, "<C-q>","<cmd>q<CR>")


vim.keymap.set({'n', 'v', 'i'}, "<F5>", "<cmd>term ./run.sh<cr>")
vim.g.mapleader= " "

--vim.keymap.set({'n','v', 'i'}, "<C-p>", ":! lgit 'now'<CR>")
vim.cmd ":Neotree reveal_file=Program.cs"

vim.keymap.set({'n','v'}, "[", "<cmd>next tab<CR>")
vim.keymap.set({'n','v'}, "]", "<cmd>previous tab<CR>")
vim.cmd.colorscheme('onedark')
