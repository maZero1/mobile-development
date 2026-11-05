package br.udesc.radar.ui.disciplinas

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.viewModels
import br.udesc.radar.databinding.FragmentDisciplinasBinding

class DisciplinasFragment : Fragment() {

    private var _binding: FragmentDisciplinasBinding? = null
    private val binding get() = _binding!!

    private val viewModel: DisciplinasViewModel by viewModels()

    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentDisciplinasBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        viewModel.titulo.observe(viewLifecycleOwner) { binding.txtTitulo.text = it }
    }

    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }
}
