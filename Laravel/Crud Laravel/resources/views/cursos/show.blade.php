@extends('layout.plantilla')

@section('title', 'Curso ' . $curso->name)

@section('content')
    <h1>Bienvenidos al curso: {{ $curso->name }} </h1>
    <a href="{{ route('cursos.index') }}">Volver a cursos</a>
    <a href="{{ route('cursos.edit', $curso->id) }}">Editar curso</a>
    <p><strong>Categoria : {{ $curso->category }}</strong></p>
    <p>{{ $curso->description }}</p>


    <form action="{{ route('cursos.destroy', $curso) }}" method="POST">
        @csrf
        @method('delete')
        <button type="submit">Eliminar</button>
    </form>
@endsection
