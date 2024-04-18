﻿using Gerenciamento_De_Tarefas.Domain.Enums;
using Gerenciamento_De_Tarefas.Domain.UsuarioModel;

namespace Gerenciamento_De_Tarefas.Domain.TarefasModel
{
    public class Tarefas
    {
        public string Id { get; set; }
        public StatusEnum Descricao { get; set; }
        public string Status { get; set;}
        public Usuario Usuario { get; set;}
        public DateTime DataInicial { get; set;}
        public DateTime DataFinal { get; set;}
        
    }
}
