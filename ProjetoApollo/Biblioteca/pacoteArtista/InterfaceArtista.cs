﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pacoteArtista
{
    interface InterfaceArtista
    {
        void InserirArtista(Artista artista);
        void DeletarArtista(Artista artista);
        void AlterarArtista(Artista artista);
        List<Artista> ListarArtista(Artista filtro);
        //bool VerificaDuplicidade(Artista artista);
    }
}
