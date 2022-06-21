﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    public class Escola
    {
        Dictionary<int, Aluno> Matriculados = new Dictionary<int, Aluno>();

        public void CadastrarAluno()
        {
            Matriculados.Add(1, new Aluno()
            {
                Matricula = 1234,
                Nome = "José",
                Sobrenome = "Silva",
                Telefone = 123456789,
            });

            Matriculados.Add(2, new Aluno()
            {
                Matricula = 5678,
                Nome = "Maria",
                Sobrenome = "Pereira",
                Telefone = 987654321,
            });
        }

        public void RemoverAluno()
        {
            Matriculados.Remove(1);
        }
    }
}

//Cadastrar Aluno.
//Remover Aluno.
//Listar todas as Matrículas com Nomes de Alunos.