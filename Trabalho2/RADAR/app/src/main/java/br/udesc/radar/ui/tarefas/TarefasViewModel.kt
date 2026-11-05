package br.udesc.radar.ui.tarefas

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel

class TarefasViewModel : ViewModel() {

    private val _titulo = MutableLiveData("Tarefas")
    val titulo: LiveData<String> = _titulo
}
