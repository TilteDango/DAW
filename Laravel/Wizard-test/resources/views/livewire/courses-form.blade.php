@section('title', 'Crea cursos Online')

<div>
    @if(!empty($successMsg))
    <div class="alert alert-success">
        {{ $successMsg }}
    </div>
    @endif

    <div class="stepwizard">
        <div class="stepwizard-row setup-panel">
            <div class="multi-wizard-step">
                <a href="#step-1" type="button" class="btn {{ $currentStep != 1 ? 'btn-default' : 'btn-primary' }}"
                    wire:click='back(1)'>1</a>
                <p>Creación</p>
            </div>
            <div class="multi-wizard-step">
                <a href="#step-2" type="button" class="btn {{ $currentStep != 2 ? 'btn-default' : 'btn-primary' }}"
                    wire:click='back(2)'>2</a>
                <p>Suscripción</p>
            </div>
            <div class="multi-wizard-step">
                <a href="#step-3" type="button" class="btn {{ $currentStep != 3 ? 'btn-default' : 'btn-primary' }}"
                    disabled="disabled" wire:click='back(3)'>3</a>
                <p>Realizar</p>
            </div>
        </div>
    </div>

    <div class="row setup-content {{ $currentStep != 1 ? 'display-none' : '' }}" id="step-1">
        <div class="col-md-12">
            <h3> Creación</h3>
            <div class="form-group">
                <label for="title">Nombre del curso</label>
                <input type="text" wire:model="name" class="form-control" id="taskTitle">
                @error('name') <span class="error">{{ $message }}</span> @enderror
            </div>
            <div class="form-group">
                <label for="price">Precio del curso</label>
                <input type="number" wire:model="price" class="form-control" id="coursePrice" />
                @error('price') <span class="error">{{ $message }}</span> @enderror
            </div>
            <div class="form-group">
                <label for="description">Detalles del curso</label>
                <textarea type="text" wire:model="description" class="form-control"
                    id="taskDetail">{{{ $description ?? '' }}}</textarea>
                @error('detail') <span class="error">{{ $message }}</span> @enderror
            </div>
            <button class="btn btn-primary nextBtn btn-lg pull-right" wire:click="firstStepSubmit"
                type="button">Avanzar</button>
        </div>
    </div>
    <div class="row setup-content {{ $currentStep != 2 ? 'display-none' : '' }}" id="step-2">
        <div class="col-md-12">
            <h3> Suscripción</h3>
            <div class="form-group">
                <label for="suscriber">Quiere suscribirse a nuestro boletin</label>
                <input type="checkbox" wire:model='suscriber'>
                @error('suscriber') <span class="error">{{ $message }}</span> @enderror
            </div>
            <button class="btn btn-primary nextBtn btn-lg pull-right" type="button"
                wire:click="secondStepSubmit">Avanzar</button>
            <button class="btn btn-danger nextBtn btn-lg pull-right" type="button"
                wire:click="back(1)">Retroceder</button>
        </div>
    </div>
    <div class="row setup-content {{ $currentStep != 3 ? 'display-none' : '' }}" id="step-3">
        <div class="col-md-12">
            <h3> Realizar</h3>
            <table class="table">
                <tr>
                    <td>Nombre del curso</td>
                    <td><strong>{{$name}}</strong></td>
                </tr>
                <tr>
                    <td>Precio del curso</td>
                    <td><strong>{{$price}}</strong></td>
                </tr>
                <tr>
                    <td>Descripción del curso:</td>
                    <td><strong>{{$description}}</strong></td>
                </tr>

                <tr>
                    <td>Suscrito</td>
                    <td><strong>{{$suscriber ? 'Suscrito' : 'No suscrito'}}</strong></td>
                </tr>
            </table>
            <button class="btn btn-success btn-lg pull-right" wire:click="submitForm" type="button">¡Crear!</button>
            <button class="btn btn-danger nextBtn btn-lg pull-right" type="button"
                wire:click="back(2)">Retroceder</button>
        </div>
    </div>
</div>