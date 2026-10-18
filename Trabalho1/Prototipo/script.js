var CORES = [
  ["Primária",         "#2563EB", "Botões, barra do topo e aba ativa", "#FFFFFF", 132, "radar_primary"],
  ["Primária escura",  "#1E40AF", "Barra de status e botão pressionado", "#FFFFFF", 96, "radar_primary_dark"],
  ["Destaque",         "#06B6D4", "Detalhes e links", "#0F172A", 96, "radar_accent"],
  ["Fundo",            "#F5F7FB", "Fundo das telas", "#0F172A", 72, "radar_background"],
  ["Superfície",       "#FFFFFF", "Listas e formulários", "#0F172A", 72, "radar_surface"],
  ["Texto",            "#0F172A", "Títulos e texto principal", "#FFFFFF", 72, "radar_text"],
  ["Texto secundário", "#64748B", "Datas e legendas", "#FFFFFF", 72, "radar_text_secondary"],
  ["Divisor",          "#E2E8F0", "Linhas e bordas", "#0F172A", 72, "radar_divider"]
];

var STATUS = [
  ["Pendente",  "#F59E0B", "O prazo ainda não chegou", "status_pending"],
  ["Concluída", "#16A34A", "Tarefa feita", "status_done"],
  ["Atrasada",  "#DC2626", "O prazo passou e a tarefa não foi concluída", "status_late"]
];

var DISCIPLINAS = ["#EF4444", "#F97316", "#EAB308", "#22C55E", "#14B8A6", "#3B82F6", "#8B5CF6", "#EC4899"];

var aviso = document.getElementById("aviso");
var timer;

function mostrarAviso(msg) {
  aviso.textContent = msg;
  aviso.className = "ativo";
  clearTimeout(timer);
  timer = setTimeout(function () { aviso.className = ""; }, 1600);
}

function copiar(texto, msg) {
  function ok() { mostrarAviso(msg); }
  function antigo() {
    var t = document.createElement("textarea");
    t.value = texto;
    document.body.appendChild(t);
    t.select();
    try { document.execCommand("copy"); } catch (e) {}
    document.body.removeChild(t);
    ok();
  }
  if (navigator.clipboard && window.isSecureContext) {
    navigator.clipboard.writeText(texto).then(ok, antigo);
  } else {
    antigo();
  }
}

function criar(tag, html) {
  var e = document.createElement(tag);
  e.innerHTML = html;
  return e;
}

CORES.forEach(function (c) {
  var li = document.createElement("li");
  li.style.background = c[1];
  li.style.color = c[3];
  li.style.setProperty("--alt", c[4] + "px");
  var b = criar("button", "<div><b>" + c[0] + "</b><small>" + c[2] + "</small></div><span>" + c[1] + "</span>");
  b.firstChild.style.pointerEvents = "none";
  b.onclick = function () { copiar(c[1], "Copiado: " + c[1]); };
  li.appendChild(b);
  document.getElementById("cores").appendChild(li);
});

STATUS.forEach(function (s) {
  var li = document.createElement("li");
  var b = criar("button", '<i style="background:' + s[1] + '"></i><div><b>' + s[0] + "</b><small>" + s[2] + "</small></div><span>" + s[1] + "</span>");
  b.onclick = function () { copiar(s[1], "Copiado: " + s[1]); };
  li.appendChild(b);
  document.getElementById("status").appendChild(li);
});

DISCIPLINAS.forEach(function (h) {
  var b = criar("button", '<i style="background:' + h + '"></i>' + h);
  b.onclick = function () { copiar(h, "Copiado: " + h); };
  document.getElementById("disc").appendChild(b);
});

var linhas = ['<?xml version="1.0" encoding="utf-8"?>', "<resources>"];
CORES.forEach(function (c) { linhas.push('    <color name="' + c[5] + '">' + c[1] + "</color>"); });
STATUS.forEach(function (s) { linhas.push('    <color name="' + s[3] + '">' + s[1] + "</color>"); });
DISCIPLINAS.forEach(function (h, i) { linhas.push('    <color name="disciplina_' + (i + 1) + '">' + h + "</color>"); });
linhas.push("</resources>");
var xml = linhas.join("\n");

document.getElementById("xml").textContent = xml;
document.getElementById("copiar-xml").onclick = function () { copiar(xml, "colors.xml copiado"); };