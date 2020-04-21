import React, { Component } from 'react';
class InputQuantityUnit extends Component{

    render(){
        return(
            <div className='col-md m-5' id='main-label'>
                <input type='text' className="form-control form-control-md" onChange={this.props.inputQuantity} />
                <select name="quantityType" id="quantityType" className='form-control'  onChange={this.props.selectinputQuantity}>
                <option value="-1" selected>Select</option>

                {
                    this.props.showType?
                    <>
                <option name="length">Feet</option>
                <option name="weight">Inch</option>
                <option name="weight">Meter</option>
                <option name="weight">Centimeter</option></> : <>
                <option name="weight">Kilograms</option>
                <option name="weight">Grams</option>
                </>
                }
                </select>
            </div>
        )
    }
}