@extends('layout.plantilla')

@section('title', 'Cursos')

@section('content')
    <h1>Bienvenidos a los cursos</h1>
    <a href="{{ route('cursos.create') }}">Crear curso</a>
    <ul>
        @foreach ($cursos as $curso)
            <a href="{{route('cursos.show', $curso->id)}}"><li>{{ $curso->name }}</li></a>
        @endforeach
    </ul>

    {{ $cursos->links() }}
@endsection
