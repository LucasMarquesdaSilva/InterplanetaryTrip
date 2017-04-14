﻿using InterplanetaryTrip.Model.classes;
using InterplanetaryTrip.Model.Entidades;
using InterplanetaryTrip.Model.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterplanetaryTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "Sim";
            do
            {
                Console.WriteLine("Bem vindo ao Sistema de Viagens Interplanetárias!");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("\n\rMenu");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Consulta");
                Console.WriteLine("3 - Atualização");
                Console.WriteLine("4 - Remoção");
                var RespostaUsuario = Console.ReadLine();

                if (RespostaUsuario == "1")
                {
                    navegarMenuCadastroGeral();
                }
                else if (RespostaUsuario == "2")
                {
                    navegarMenuConsultaGeral();
                }
                else if (RespostaUsuario == "3")
                {
                    Console.WriteLine("Menu 3 - Atualizãção");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("1 - Atualizar Planeta");
                    Console.WriteLine("2 - Atualizar Cliente");
                    Console.WriteLine("3 - Atualizar Transporte");
                    Console.WriteLine("4 - Atualizar Viagem");
                    var RespostaUsuarioAtualizacao = Console.ReadLine();
                    if (RespostaUsuarioAtualizacao == "1")
                    {

                    }
                    else if (RespostaUsuarioAtualizacao == "2")
                    {

                    }
                    else if (RespostaUsuarioAtualizacao == "3")
                    {

                    }
                    else if (RespostaUsuarioAtualizacao == "4")
                    {

                    }
                }
                else if (RespostaUsuario == "4")
                {
                    Console.WriteLine("Menu 4 - Excluir");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("1 - Excluir Planeta");
                    Console.WriteLine("2 - Excluir Cliente");
                    Console.WriteLine("3 - Excluir Transporte");
                    Console.WriteLine("4 - Excluir Viagem");
                    var RespostaUsuarioExcluir = Console.ReadLine();
                    if (RespostaUsuarioExcluir == "1")
                    {
                        navegarRemocaoPlaneta();
                    }
                    else if (RespostaUsuarioExcluir == "2")
                    {

                    }
                    else if (RespostaUsuarioExcluir == "3")
                    {

                    }
                    else if (RespostaUsuarioExcluir == "4")
                    {

                    }
                }
                Console.WriteLine("Deseja continuar utilizando o nosso sistema?");
                resposta = Console.ReadLine().ToLower();

            } while ((resposta == "sim"));
        }

        private static void navegarRemocaoPlaneta()
        {
            try
            {
                Console.WriteLine("Digite o nome do planeta que voce deseja excluir:");
                var nomePlaneta = Console.ReadLine();
                RepositorioCrud<Planeta> operacaoPlaneta = new RepositorioCrud<Planeta>();
                var planetas = operacaoPlaneta.Consultar("planeta_sps", nomePlaneta, "@Nome");
                foreach (var item in planetas)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("Informe o id do planeta para ser excluido: ");
                var idPlaneta = Console.ReadLine();
                operacaoPlaneta.Remover("planeta_spd", Convert.ToInt32(idPlaneta), "@id");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops: {0}", e.Message);
            }
        }

        private static void navegarMenuConsultaGeral()
        {
            Console.WriteLine("Menu 2 - Consulta");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1 - Consultar Planeta");
            Console.WriteLine("2 - Consultar Cliente");
            Console.WriteLine("3 - Consultar Transporte");
            Console.WriteLine("4 - Consultar Viagem");
            var RespostaUsuarioConsulta = Console.ReadLine();
            if (RespostaUsuarioConsulta == "1")
            {
                navegarConsultaPlaneta();
            }
            else if (RespostaUsuarioConsulta == "2")
            {
                navegarConsultaCliente();
            }
            else if (RespostaUsuarioConsulta == "3")
            {
                navegarConsultaTransporte();
            }
            else if (RespostaUsuarioConsulta == "4")
            {
                navegarConsultaViagem();
            }
        }

        private static void navegarConsultaViagem()
        {
            try
            {
                Console.WriteLine("Qual o id da viagem que você deseja consultar?");
                var respostaConsultaViagem = Console.ReadLine();
                RepositorioCrud<ViagemConsulta> consultaCliente = new RepositorioCrud<ViagemConsulta>();
                var viagens = consultaCliente.Consultar("viagem_sps", Convert.ToInt32(respostaConsultaViagem), "@Id");
                foreach (var item in viagens)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops: {0} ", e.Message);
            }
        }

        private static void navegarConsultaTransporte()
        {
            try
            {
                Console.WriteLine("Qual o nome do transporte que você deseja consultar?");
                var respostaConsultaTransporte = Console.ReadLine();
                RepositorioCrud<Transporte> consultaCliente = new RepositorioCrud<Transporte>();
                var transportes = consultaCliente.Consultar("transporte_sps", respostaConsultaTransporte, "@Nome");
                foreach (var item in transportes)
                {
                    Console.WriteLine(item.ToString());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops: {0} ", e.Message);
            }
        }

        private static void navegarConsultaCliente()
        {
            try
            {
                Console.WriteLine("Qual o nome do cliente que você deseja consultar?");
                var respostaConsultaCliente = Console.ReadLine();
                RepositorioCrud<Cliente> consultaCliente = new RepositorioCrud<Cliente>();
                var clientes = consultaCliente.Consultar("cliente_sps", respostaConsultaCliente, "@Nome");
                foreach (var item in clientes)
                {
                    Console.WriteLine(item.ToString());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops: {0} ", e.Message);
            }
        }

        private static void navegarConsultaPlaneta()
        {
            try
            {
                Console.WriteLine("Qual o nome do planeta voce deseja consultar?");
                var respostaConsultaPlaneta = Console.ReadLine();
                RepositorioCrud<Planeta> consultaPlaneta = new RepositorioCrud<Planeta>();
                var planetas = consultaPlaneta.Consultar("planeta_sps", respostaConsultaPlaneta, "@Nome");
                foreach (var item in planetas)
                {
                    Console.WriteLine(item.ToString());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops: {0}", e.Message);
            }
        }

        private static void navegarMenuCadastroGeral()
        {
            Console.WriteLine("Menu 1 - Cadastro");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1 - Cadastrar Planeta");
            Console.WriteLine("2 - Cadastrar Cliente");
            Console.WriteLine("3 - Cadastrar Transporte");
            Console.WriteLine("4 - Cadastrar Viagem");
            var respostaUsuarioCadastro = Console.ReadLine();
            if (respostaUsuarioCadastro == "1")
            {
                navegarCadastroPlaneta();

            }
            else if (respostaUsuarioCadastro == "2")
            {
                navegarCadastroCliente();
            }
            else if (respostaUsuarioCadastro == "3")
            {
                navegarCadastroTransporte();

            }
            else if (respostaUsuarioCadastro == "4")
            {
                navegarCadastroViagem();

            }
        }

        private static void navegarCadastroViagem()
        {
            Console.WriteLine("Cadastro de Viagem");
            Console.WriteLine("---------------------");
            Console.WriteLine("Id Planeta origem:");
            var idPlanetaOrigem = Console.ReadLine();
            Console.WriteLine("Id Planeta destino:");
            var idPlanetaDestino = Console.ReadLine();
            Console.WriteLine("Id Cliente:");
            var idCliente = Console.ReadLine();
            Console.WriteLine("Id Transporte:");
            var idTransporte = Console.ReadLine();
            Console.WriteLine("Valor: R$");
            var valor = Console.ReadLine();
            Console.WriteLine("Tempo:");
            var tempo = Console.ReadLine();

            Viagem viagem = new Viagem(Convert.ToInt32(idPlanetaOrigem), Convert.ToInt32(idPlanetaDestino),
                Convert.ToInt32(idCliente), Convert.ToInt32(idTransporte), Convert.ToDecimal(valor), tempo);
            var repositorioViagem = new RepositorioCrud<Viagem>();
            repositorioViagem.Cadastrar(viagem, "viagem_spi");
        }

        private static void navegarCadastroTransporte()
        {
            Console.WriteLine("Cadastro de Transporte");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome do transporte:");
            var nomeTransporte = Console.ReadLine();
            Console.WriteLine("Terreno(AR/ TERRA/ MAR/ TELETRANSPORTE):");
            var terreno = Console.ReadLine();
            Transporte transporte = new Transporte(nomeTransporte, terreno);
            var repositorioTransporte = new RepositorioCrud<Transporte>();
            repositorioTransporte.Cadastrar(transporte, "transporte_spi");
        }

        private static void navegarCadastroCliente()
        {
            Console.WriteLine("Cadastro de Cliente");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome Completo:");
            var Nome = Console.ReadLine();
            Console.WriteLine("Número do Documento:");
            var Documento = Console.ReadLine();
            Console.WriteLine("Tipo da éspecie:");
            var TipoEspecie = Console.ReadLine();
            Console.WriteLine("Cor:");
            var Cor = Console.ReadLine();
            Console.WriteLine("Quantidade de Braços:");
            var QtdBracos = Console.ReadLine();
            Console.WriteLine("Quantidade de Pernas:");
            var QtdPernas = Console.ReadLine();
            Console.WriteLine("Quantidade de Cabeça:");
            var QtdCabeca = Console.ReadLine();
            Console.WriteLine("Você respira?");
            var Respira = Console.ReadLine().ToLower();
            var RespostaRespira = true;

            if (Respira == "sim")
            {
                RespostaRespira = true;
            }
            else
            {
                RespostaRespira = false;
            }

            try
            {
                Cliente cliente = new Cliente(Nome, Documento, TipoEspecie, Cor, Convert.ToInt32(QtdBracos), Convert.ToInt32(QtdPernas), Convert.ToInt32(QtdCabeca), RespostaRespira);
                RepositorioCrud<Cliente> repositorioCliente = new RepositorioCrud<Cliente>();

                repositorioCliente.Cadastrar(cliente, "cliente_spi");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error message: {0} ", ex.Message);
            }
        }

        private static void navegarCadastroPlaneta()
        {
            Console.WriteLine("Cadastro de Planeta");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome do Planeta:");
            var NomePlaneta = Console.ReadLine();
            Console.WriteLine("Descrição do Planeta:");
            var DescricaoPlaneta = Console.ReadLine();
            Console.WriteLine("Possui Oxigênio?");
            var RespostaPossuiOxigenio = Console.ReadLine().ToLower();
            var PossuiOxigenio = true;
            if (RespostaPossuiOxigenio == "Sim")
            {
                PossuiOxigenio = true;
            }
            else if (RespostaPossuiOxigenio == "não" || RespostaPossuiOxigenio == "nao")
            {
                PossuiOxigenio = false;
            }
            try
            {
                Planeta Planeta = new Planeta(NomePlaneta, DescricaoPlaneta, PossuiOxigenio);
                var RepositorioPlaneta = new RepositorioCrud<Planeta>();
                RepositorioPlaneta.Cadastrar(Planeta, "planeta_spi");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops! {0} ", e.Message);
            }
        }
    }
}