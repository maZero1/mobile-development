package br.udesc.radar.ui.ajustes

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel

class AjustesViewModel : ViewModel() {

    private val _titulo = MutableLiveData("Ajustes")
    val titulo: LiveData<String> = _titulo
}
