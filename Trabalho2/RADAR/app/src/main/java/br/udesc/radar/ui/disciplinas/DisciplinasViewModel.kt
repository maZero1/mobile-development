package br.udesc.radar.ui.disciplinas

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel

class DisciplinasViewModel : ViewModel() {

    private val _titulo = MutableLiveData("Disciplinas")
    val titulo: LiveData<String> = _titulo
}
