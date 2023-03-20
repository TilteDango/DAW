@extends('layout.plantilla')

@section('title', 'Editar')

@section('content')
    <h1>En esta página podras editar un curso</h1>

    <form action="{{ route('cursos.update', $curso) }}" method="POST">
        @csrf
        @method('put')

        <label for="name">
            Nombre
        </label>
        <input type="text" name="name" value="{{ old('name', $curso->name) }}">

        @error('name')
            <small>*{{ $message }}</small>
        @enderror

        <label for="description">
            Descripción
        </label>
        <textarea name="description" cols="30" rows="10">{{ old('description', $curso->description) }}</textarea>

        @error('name')
            <small>*{{ $message }}</small>
        @enderror

        <label for="category">
            Categoria
        </label>
        <input type="text" name="category" value="{{ old('category', $curso->category) }}">

        @error('name')
            <small>*{{ $message }}</small>
        @enderror

        <input type="submit">
    </form>
@endsection
