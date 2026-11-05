# RADAR - esqueleto (etapa 2)

O que tem aqui: Bottom Navigation com 4 abas (Painel, Disciplinas, Tarefas, Ajustes),
cada aba com Fragment + ViewModel (MVVM) e ViewBinding. Ainda sem Room, Retrofit nem dados reais.

## Como aplicar

1. Android Studio > New Project > **Empty Views Activity**
    - Name: RADAR | Package: `br.udesc.radar` | Language: Kotlin | Minimum SDK: API 26
    - Se o package for outro, troque `br.udesc.radar` nos arquivos .kt e no nav_graph.xml.
2. Copie a pasta `app/src/main` deste zip por cima da `app/src/main` do projeto
   (vai sobrescrever `MainActivity.kt` e `activity_main.xml`, é isso mesmo).
3. Em `res/values/strings.xml` (do template) deixe `app_name` como `RADAR`.
4. No `app/build.gradle.kts` ative o ViewBinding e adicione as dependências:

```kotlin
android {
    buildFeatures {
        viewBinding = true
    }
}

dependencies {
    // Navigation (Fragments + Bottom Navigation)
    implementation("androidx.navigation:navigation-fragment-ktx:2.7.7")
    implementation("androidx.navigation:navigation-ui-ktx:2.7.7")
    // ViewModel + LiveData (MVVM)
    implementation("androidx.lifecycle:lifecycle-viewmodel-ktx:2.8.4")
    implementation("androidx.lifecycle:lifecycle-livedata-ktx:2.8.4")
}
```

As versões são só pontos de partida. Se o Android Studio sugerir atualizar, tudo bem.
5. Sync, rodar no emulador. Deve abrir com 4 abas trocando entre si.

## Estrutura de pacotes (o que já existe e o que vem)

```
br.udesc.radar
 ├─ MainActivity.kt
 ├─ ui/            painel, disciplinas, tarefas, ajustes   (Fragment + ViewModel de cada tela)
 ├─ data/local/    (etapa 3) entidades Room + DAOs
 ├─ data/remote/   (etapa 6) Retrofit + BrasilAPI
 ├─ data/repository/ (etapa 3) repositórios
 └─ util/          (depois) notificações, câmera, sensor
```

## Dependências que entram mais pra frente

Room e Retrofit só entram nas etapas 3 e 6 (Room precisa do plugin KSP, que tem que bater
com a versão do Kotlin do projeto). Ao chegar lá, a gente vê com as versões que o seu projeto usa.
