package br.udesc.radar.ui.painel

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel

class PainelViewModel : ViewModel() {

    private val _titulo = MutableLiveData("Painel")
    val titulo: LiveData<String> = _titulo
}
